using LINQ.DataSources;
using LINQ.Models;
using System.Diagnostics.Metrics;
IEnumerable<object> customerGroupsQuery = null;

#region Q1
//var top3Products = Source.ProductList
//   .OrderByDescending(p => p.UnitPrice)
//   .Take(3)
//   .ToList();

//foreach (var product in top3Products)
//{
//    Console.WriteLine(product);
//}
#endregion
#region Q2
//int pageSize = 5;
//int pageNumber = 2;

//var page2Products = Source.ProductList
//    .Skip((pageNumber - 1) * pageSize)
//    .Take(pageSize)
//    .ToList();

//foreach (var product in page2Products)
//{
//    Console.WriteLine(product);
//}
#endregion
#region Q3
//var cheapProducts = Source.ProductList
//   .OrderBy(p => p.UnitPrice)
//   .TakeWhile(p => p.UnitPrice < 25.00m)
//   .ToList();

//foreach (var product in cheapProducts)
//{
//    Console.WriteLine(product);
//}
#endregion
#region Q4
//bool allSeafoodInStock = Source.ProductList
//    .Where(p => p.Category == "Seafood")
//    .All(p => p.UnitsInStock > 0);

//Console.WriteLine($"Are all Seafood products in stock? {allSeafoodInStock}");
#endregion
#region Q5
//int[] ids = { 3, 9, 13, 18 };

//bool containsNine = ids.Contains(9);

//Console.WriteLine($"Does the list contain 9? {containsNine}");
#endregion
#region Q6
//var productGroups = Source.ProductList
//   .GroupBy(p => p.Category);

//foreach (var group in productGroups)
//{
//    Console.WriteLine($"Category: {group.Key}, Count: {group.Count()}");
//}
#endregion
#region Q7
//var categoryProductNames = Source.ProductList
//   .GroupBy(p => p.Category)
//   .Select(g => new
//   {
//       Category = g.Key,
//       ProductNames = g.Select(p => p.ProductName)
//   });

//foreach (var item in categoryProductNames)
//{
//    Console.WriteLine($"Category: {item.Category}");
//    foreach (var name in item.ProductNames)
//    {
//        Console.WriteLine($" - {name}");
//    }
//}
#endregion
#region Q8
//var categoriesWithManyProducts = Source.ProductList
//   .GroupBy(p => p.Category)
//   .Where(g => g.Count() > 3)
//   .Select(g => g.Key);

//foreach (var category in categoriesWithManyProducts)
//{
//    Console.WriteLine($"Category with > 3 products: {category}");
//}
#endregion
#region Q9
//var customerGroupsQuery2 = from c in Source.CustomerList
//group c by c.Country into g
//select new
//{
//           Country = g.Key,
//    Count = g.Count(),
//    TotalOrderValue = g.SelectMany(cust => cust.Orders).Sum(o => o.Total)
//};

//foreach (var item in customerGroupsQuery2)
//{
//    Console.WriteLine($"Country: {item.Country}, Customers Count: {item.Count}, Total Orders Value: {item.TotalOrderValue:C2}");
//}

#endregion
#region Q10
//int totalUnitsInStock = Source.ProductList
//    .Sum(p => p.UnitsInStock);

//Console.WriteLine($"Total units in stock: {totalUnitsInStock}");
#endregion
#region Q11
//decimal cheapestPrice = Source.ProductList.Min(p => p.UnitPrice);
//decimal mostExpensivePrice = Source.ProductList.Max(p => p.UnitPrice);

//Console.WriteLine($"Cheapest Price: {cheapestPrice:C2}");
//Console.WriteLine($"Most Expensive Price: {mostExpensivePrice:C2}");
#endregion

Console.ReadKey();
