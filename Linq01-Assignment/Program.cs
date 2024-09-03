using System.Linq;
using static Linq01_Assignment.ListGenerator;

namespace Linq01_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators
            #region 1. Find all products that are out of stock.
            var OutOfStockProducts = ProductsList.Where(P => P.UnitsInStock == 0);
            //foreach (var Product in OutOfStockProducts) { Console.WriteLine(Product); }
            #endregion
            #region 2. Find all products that are in stock and cost more than 3.00 per unit.
            var InStockProducts = ProductsList.Where(P => P.UnitsInStock > 0 && P.UnitPrice > 3);
            //foreach (var Product in InStockProducts) { Console.WriteLine(Product); }
            #endregion
            #region 3. Returns digits whose name is shorter than their value.
            String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var digits = Arr.Where((d, i) => d.Length > i);
            //foreach (var digit in digits) { Console.WriteLine(digit); }
            #endregion
            #endregion
            #region LINQ - Element Operators
            #region 1. Get first Product out of Stock 
            var FirstProductOutOfStock = ProductsList.FirstOrDefault(p=>p.UnitsInStock==0);
            //Console.WriteLine(FirstProductOutOfStock);
            #endregion
            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            var FirstProductPriceLargerThan100 = ProductsList.FirstOrDefault(p => p.UnitPrice > 100);
            if (FirstProductPriceLargerThan100 == null)
            {
                Console.WriteLine("Null");
            }
            else
            {
                //Console.WriteLine(FirstProductPriceLargerThan100);
            }
            #endregion
            #region MyRegion
            int[] Arr01 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int secondNumberGreaterThanFive = Arr01.Where(n => n > 5).ElementAt(1);
            //Console.WriteLine("The second number greater than 5 is: " + secondNumberGreaterThanFive);
            #endregion
            #endregion
            #region LINQ - Aggregate Operators
            #region 1. Uses Count to get the number of odd numbers in the array
            int[] Arr03 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int oddNumbersCount = Arr03.Count(n => n % 2 != 0);
            // Console.WriteLine("The number of odd numbers in the array is: " + oddNumbersCount); 
            #endregion
            #region 2. Return a list of customers and how many orders each has.
            var Customers = CustomersList.SelectMany((c) =>c.Orders ,(c,o) => new { c.CustomerID, c.CustomerName, o });
            //foreach (var customer in Customers)
            //{
            //    Console.WriteLine(customer);
            //}
            #endregion
            #region Get the total of the numbers in an array.

            int[] Arr00 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int total = Arr00.Sum();

           // Console.WriteLine("The total of the numbers in the array is: " + total);
            #endregion
            #endregion
        }
    }
}
