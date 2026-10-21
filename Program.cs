using LINQ.DataSources;
using LINQ.Models;
namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            #region Q12
            //var distinctCategories = Source.ProductList
            //    .Select(p => p.Category)
            //    .Distinct();

            //foreach (var category in distinctCategories)
            //{
            //    Console.WriteLine(category);
            //}
            #endregion
            #region Q13
            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };

            //var exceptResult = setA.Except(setB);

            //foreach (var id in exceptResult)
            //{
            //    Console.WriteLine(id);
            //}
            #endregion
            #region Q14
            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };

            //var uniqueCountries = list1.Except(list2, StringComparer.OrdinalIgnoreCase);

            //foreach (var country in uniqueCountries)
            //{
            //    Console.WriteLine(country);
            //}
            #endregion
            #region Q15
            //Dictionary<int, Product> productDict = Source.ProductList
            //                        .ToDictionary(p => p.ProductID);

            //if (productDict.TryGetValue(18, out Product? product))
            //{
            //    Console.WriteLine(product);
            //}
            #endregion
            #region Q16
            //Product? firstExpensive = Source.ProductList
            //        .First(p => p.UnitPrice > 50.00m);

            //Console.WriteLine(firstExpensive);
            #endregion
            #region Q17
            //Product? productOver500 = Source.ProductList
            //        .FirstOrDefault(p => p.UnitPrice > 500.00m);

            //if (productOver500 == null)
            //{
            //    Console.WriteLine("No product found with price > $500 (returns null safely).");
            //}
            //else
            //{
            //    Console.WriteLine(productOver500);
            //}
            #endregion
            #region Q18
            //var multTable7 = Enumerable.Range(1, 12)
            //   .Select(i => i * 7);

            //foreach (var val in multTable7)
            //{
            //    Console.Write(val + " ");
            //}
            //Console.WriteLine();
            #endregion
            #region Q19
            //var evenNumbers = Enumerable.Range(1, 30)
            //   .Where(n => n % 2 == 0);

            //foreach (var num in evenNumbers)
            //{
            //    Console.Write(num + " ");
            //}
            //Console.WriteLine();
            #endregion


            Console.ReadKey();
        }
    }
}