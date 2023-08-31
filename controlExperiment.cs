// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace WarehouseRecord
// {

//     public class WareHouseData
//     {
//         // private string W7, W3, W2, W1, W5, W4, W8, W6;

//         private Dictionary<string, string> matchingWarehouses = new Dictionary<string, string>();
//         private Dictionary<string, string> stock = new Dictionary<string, string>();


//         public void instruction()
//         {
//             Console.WriteLine("Enter State Initials: ");
//             string state = Console.ReadLine();
//             Console.WriteLine("Enter Sku");
//             string sku = Console.ReadLine();

//             StateWareHouse(state);
//             StockData(sku);
//         }

//         public void StateWareHouse(string state)
//         {

//             string path = "/Users/admin/Documents/Projects/DotNet/WarehouseRecord/warehouses_11.csv";

//             using (StreamReader reader = new StreamReader(path))
//             {
//                 string line;

//                 while ((line = reader.ReadLine()) != null)
//                 {
//                     string[] values = line.Split(',');
//                     for (int i = 0; i < values.Length; i++)
//                     {
//                         if (values[i].Contains(state, StringComparison.OrdinalIgnoreCase))
//                         {
//                             matchingWarehouses[values[i]] = values[i];
//                             foreach (KeyValuePair<string, string> Kvp in matchingWarehouses)
//                             {
//                                 string matchingWarehouseName = Kvp.Key;
//                                 string matchingWarehouseValue = Kvp.Value;

//                                 // Console.WriteLine($"key:{matchingWarehouseName}, value:{matchingWarehouseValue}");
//                             }
//                         }
//                     }
//                 }



//             }

//         }

//         public void StockData(string number)
//         {

//             string newPath = "/Users/admin/Documents/Projects/DotNet/WarehouseRecord/warehouses-with-skus_11.csv";
//             using (StreamReader newReader = new StreamReader(newPath))
//             {
//                 string line;


//                 while ((line = newReader.ReadLine()) != null)
//                 {
//                     string[] values = line.Split(',');
//                     string sku = values[0];
//                     // string Warehouse1 = values[1];
//                     // string Warehouse2 = values[2];
//                     // string Warehouse3 = values[3];
//                     // string Warehouse4 = values[4];
//                     // string Warehouse5 = values[5];
//                     // string Warehouse6 = values[6];
//                     // string Warehouse7 = values[7];
//                     // string Warehouse8 = values[8];

//                     for (int i = 0; i < values.Length; i++)
//                     {
//                         if (sku.Contains(number))
//                         {
//                             stock[values[i]] = values[i];

//                             foreach (KeyValuePair<string, string> matchingKvp in matchingWarehouses)
//                             {
//                                 string matchingWarehouseName = matchingKvp.Key;
//                                 string matchingWarehouseValue = matchingKvp.Value;

//                                 foreach (KeyValuePair<string, string> stockKvp in stock)
//                                 {
//                                     string stockWarehouseName = stockKvp.Key;
//                                     string stockValue = stockKvp.Value;

//                                     if (stockWarehouseName == matchingWarehouseName)
//                                     {
//                                         Console.WriteLine($"{sku}, {stockValue}");

//                                     }
//                                 }
//                             }
//                         }

//                     }



//                     // if (sku.Contains(number))

//                     // {

//                     //     foreach (KeyValuePair<string, string> matchingKvp in matchingWarehouses)
//                     //     {
//                     //         string matchingWarehouseName = matchingKvp.Key;
//                     //         string matchingWarehouseValue = matchingKvp.Value;

//                     //         foreach (KeyValuePair<string, string> stockKvp in stock)
//                     //         {
//                     //             string stockWarehouseName = stockKvp.Key;
//                     //             string stockValue = stockKvp.Value;

//                     //             if (stockWarehouseName == matchingWarehouseName)
//                     //             {
//                     //                 Console.WriteLine($"{sku}, {stockValue}");

//                     //             }
//                     //         }
//                     //     }




//                 }
//             }




//         }



//     }
// }
