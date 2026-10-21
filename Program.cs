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

            Console.ReadKey();
		}
	}
}
