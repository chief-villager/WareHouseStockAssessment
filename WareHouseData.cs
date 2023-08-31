using System;
using System.Collections.Generic;
using System.IO;

namespace WarehouseRecord
{
    public class WareHouseData
    {
        public string[] StateWareHouses = new string[8];
        public string[] SkuWareHouseData = new string[8];

        public void Run()
        {
            Console.WriteLine("Enter state:");
            string state = Console.ReadLine().ToUpper();

            Console.WriteLine("Enter state:");
            string sku = Console.ReadLine();

            GetWareHouseStockData(state,sku);
        }
        public void GetWareHouseStockData(string state, string sku)
        {
            using (StreamReader StateReader = new StreamReader(Paths.WareHousePath))
            {
                var Firstline = StateReader.ReadLine();
                var WareHouseHeader = Firstline.Split(",");
                string? OtherLine;

                while ((OtherLine = StateReader.ReadLine()) != null)
                {
                    var value = OtherLine.Split(",");
                    IEnumerable<string> matchUp = value.Select((content, i) => content.Equals(state) ? WareHouseHeader[i]:StateWareHouses[i]);
                    StateWareHouses = matchUp.ToArray();
                }
            }
            using (StreamReader SkuReader = new StreamReader(Paths.skuPath))
            {
                var Firstline = SkuReader.ReadLine();
                var skuHeader = Firstline.Split(",");
                string OtherLine;
                while ((OtherLine = SkuReader.ReadLine()) != null)
                {
                    var skuValue = OtherLine.Split("\n");
                    string [] stocks = skuValue[0].Split(",");
                    SkuWareHouseData = stocks.Skip(1).ToArray();

                    if (stocks[0].Equals(sku))
                    {
                        //Zip() joins the array together and we can compare and manipulate.
                        StateWareHouses.Zip(SkuWareHouseData,(houses,data) => new {stateWareHouses = houses , skuWareHousedata = data}).Where(x =>x.stateWareHouses != null && x.skuWareHousedata != null).ToList()
                        .ForEach(x => Console.WriteLine($"{x.stateWareHouses}: {x.skuWareHousedata}"));

                    }

                }
            }



        }






    }
}

