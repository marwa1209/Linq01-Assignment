﻿using static Demo.ListGenerator;
namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Session01
            #region What Is Linq
            ///Linq => Language Integrated Query
            ///Linq +40 Extention Methods
            ///Extention Methods For All Collection That Implement "IEnumrable" Interface 
            ///Named As Linq Operators Existed At Class Enumrable
            ///Categorized Into 13 Categorey

            List<int> Numbers = new List<int>() { 1, 2, 5, 6, 7, 9, 12, 14, 15, 19 };
            List<int> OddNumbers = Numbers.Where(x => x % 2 == 1).ToList();
            //foreach (int x in OddNumbers) { Console.WriteLine(x); }
            ///you can use "linq operator " Aganist the data that stored in sequence
            ///regardless data store
            ///Sequence=>from class that implement built-in interface "IEnumrable"
            ///local Sequence=>like Numbers[linq against object] [linq to object]/ xml file [linq against xml] [linq to xml]
            ///remote Sequence=>[linq against EntityFrameWork] [linq to EntityFrameWork]
            #endregion
            #region Linq Syntax[Fluent ,Query]
            List<int> Numbers01 = new List<int>() { 1, 2, 5, 6, 7, 9, 12, 14, 15, 19 };
            #region Fluent Syntax
            /// 1.Fluent Syntax
            ///    1.1.Call Linq Operator as a static Method
            /// List<int> OddNumbers01 = Enumerable.Where(Numbers01,x => x % 2 == 1).ToList();
            /// var OddNumbers01 = Enumerable.Where(Numbers01,x => x % 2 == 1);
            /// foreach (int x in OddNumbers01) { Console.WriteLine(x); }
            ///    1.2.Call Linq Operator as Extention Method[RECOMMENDED]
            /// List<int> OddNumbers01 = Numbers01.Where(x => x % 2 == 1).ToList();
            /// var OddNumbers01 = Numbers01.Where(x => x % 2 == 1);
            ///foreach (int x in OddNumbers01) { Console.WriteLine(x);  
            #endregion}
            #region Query Syntax
            //select
            //from Numbers N
            //where N%2==1
            var oddNumbers = from N in Numbers01
                             where N % 2 == 1
                             select N;
            //foreach (var number in oddNumbers) { Console.WriteLine(number); };
            //must begin with from and end with select or groupBy
            #endregion

            #endregion
            #region Exectuations ways
            #region deffered execuation [Latest version of data]
            //List<int> Numbers02 = new List<int>() { 1, 2, 5, 6, 7, 9, 12, 14, 15, 19 };
            //var evenNumbers = Numbers02.Where(x => x % 2 == 0);
            //Numbers02.AddRange(new List<int>() { 100, 101, 102, 103, 104 });
            ////where is Executed with deffered execuation[مؤجل]
            //foreach (var number in evenNumbers) { Console.WriteLine(number); };
            #endregion
            #region immediate execuation[Elements Operators , Casting Operators , Aggregate Operators]
            List<int> Numbers02 = new List<int>() { 1, 2, 5, 6, 7, 9, 12, 14, 15, 19 };
            var evenNumbers = Numbers02.Where(x => x % 2 == 0).ToList();
            Numbers02.AddRange(new List<int>() { 100, 101, 102, 103, 104 });
            // foreach (var number in evenNumbers) { Console.WriteLine(number); };
            #endregion
            #endregion
            #region Set Up Data         
            //Console.WriteLine(ProductsList[0]);
            //Console.WriteLine(CustomersList[0]);
            #endregion
            #region Filtration [Restrecation] Operators-"Where"(deffered execuation)
            #region Get Products Out Of Stock[example 01]
            //Get Products Out Of Stock
            //fluent Syntax
            //var Result = ProductsList.Where(x => x.UnitsInStock == 0);
            //query syntax
            //  var Result = from N in ProductsList
            //           where N.UnitsInStock==0
            //         select N;
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Get Products in  Stock & in categorey of meat/poultry[example 02]
            //fluent Syntax
            // var Result = ProductsList.Where(x => x.UnitsInStock>0 && x.Category== "Meat/Poultry");
            //query syntax
            //Result = from N in ProductsList
            //         where N.UnitsInStock > 0 && N.Category == "Meat/Poultry"
            //          select N;
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Indexed Where[valid only with fluent syntax ]
            //fluent Syntax
            var Result = ProductsList.Where((x, i) => x.UnitsInStock > 0 && i < 9);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion
            #region Transformation [Projection] Operators [Select , Select Many]
            #region Select Product Name
            //Select Product Name
            //fluent syntax
            //var Result0 = ProductsList.Select(x=>x.ProductName);
            //Query Syntax
            //var Result0 = from p in ProductsList
            //              select p.ProductName;
            //foreach (var item in Result0)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Select Customer Name
            ////fluent syntax
            //var Result0 = CustomersList.Select(x=>x.CustomerName);
            ////Query Syntax
            // Result0 = from p in CustomersList
            //           select p.CustomerName;
            //foreach (var item in Result0)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Select Customer Orders
            ////fluent syntax
            //var Result0 = CustomersList.SelectMany(x => x.Orders);
            ////Query Syntax
            //Result0 = from p in CustomersList
            //          from o in p.Orders
            //          select o;
            //foreach (var item in Result0)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Select ProductId And Product Name
            ////fluent syntax
            //var Result0 = ProductsList.Select(x =>new  {x.ProductID , x.ProductName } );
            ////Query Syntax
            //Result0 = from p in ProductsList
            //          select new { p.ProductID  ,  p.ProductName };
            //foreach (var item in Result0)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Select Product In Stock and Apply 10% discount on its price
            ////fluent syntax
            //var Result0 = ProductsList.Where(x => x.UnitsInStock > 0).Select(x => new { x.ProductID, x.ProductName ,oldPrice=x.UnitPrice , PriceAfterDiscount=x.UnitPrice-(x.UnitPrice*0.1M)});
            ////Query Syntax
            //Result0 = from x in ProductsList
            //          where x.UnitsInStock>0
            //          select new { x.ProductID, x.ProductName, oldPrice = x.UnitPrice, PriceAfterDiscount = x.UnitPrice - (x.UnitPrice * 0.1M) };
            //foreach (var item in Result0)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion
            #region Ordering Operators [Ascending , Descending ,Reverse ,ThenBy ,ThenByDescending]
            #region Get Products Orderd By Price Asc
            // //fluent syntax
            // var Result0 = ProductsList.OrderBy(x => x.UnitPrice);
            //// Query Syntax
            //  Result0 = from p in ProductsList
            //            orderby p.UnitPrice
            //            select p;
            // foreach (var item in Result0)
            // {
            //     Console.WriteLine(item);
            // }
            #endregion
            #region Get Products Orderd By Price Desc
            ////fluent syntax
            //var Result0 = ProductsList.OrderByDescending(x => x.UnitPrice);
            //// Query Syntax
            //Result0 = from p in ProductsList
            //          orderby p.UnitPrice descending
            //          select p;
            //foreach (var item in Result0)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Get Products Orderd By Price Asc And Numbers Of Items In Stock
            ////fluent syntax
            //var Result0 = ProductsList.OrderBy(x => x.UnitPrice).ThenByDescending(x => x.UnitsInStock).Reverse();
            ////  var Result02 = ProductsList.Where(x => x.UnitsInStock==0).Reverse();

            //foreach (var item in Result0)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion
            #region Elements Operators -Immediate Execuation [Valid Only With Fluent Syntax][First,Last,FirstOrDefault,LastOrDefault,ElementAt,ElementAtOrDefault,Single,SingleOrDefault]
            //fluent syntax
            //   var Result0 = ProductsList.First(); //get first element
            //Result0 = ProductsList.Last(); //get Last element

            //  Console.WriteLine(Result0?.ProductName??"Not Found");
            //     Result0 = ProductsList.FirstOrDefault(); //get first element
            //     Result0 = ProductsList.LastOrDefault(); //get Last element
            //     Result0 = ProductsList.FirstOrDefault(p=>p.UnitsInStock>0); //get first element
            //     Result0 = ProductsList.LastOrDefault(p => p.UnitsInStock > 0); //get Last element
            ////     Result0 = ProductsList.ElementAt( 99); //excepton
            //     Result0 = ProductsList.ElementAtOrDefault( 99); 

            //Result0 = ProductsList.Single( ); //exception
            // Result0 = ProductsList.Single(p=>p.ProductID==1);  //exception
            // Result0 = ProductsList.SingleOrDefault();  

            //  Console.WriteLine(Result0?.ProductName ?? "Not Found");
            // Query Syntax
            //Result0 = from p in ProductsList
            //          orderby p.UnitPrice
            //          select p;

            #endregion
            #endregion
            #region Session02
            #region Casting Operators [immediate Execuation]
            #region tolist()
            // List<Product> Products = ProductsList.Where(p => p.UnitsInStock == 0).ToList(); 
            #endregion
            #region toArray()
            //  Product[] Products = ProductsList.Where(p => p.UnitsInStock == 0).ToArray();//casting with to array 
            #endregion
            #region ToDictionary()
            Dictionary<long, Product> Result002 = ProductsList.Where(p => p.UnitsInStock == 0).ToDictionary(p => p.ProductID);
            //foreach (var item in Result002)
            //{
            //    Console.WriteLine(item.Value);
            //} 
            #endregion
            #endregion
            #region Generation Operators-Deffered Execuation
            //valid only with fluent syntax
            //the only way to call them as static method from class enumrable
            var result00 = Enumerable.Range(0,100);
             result00 = Enumerable.Repeat(2, 100);

            foreach (var x in result00) { Console.WriteLine(x); }
            #endregion
            #region SET OPERATORS
            var result0 = Enumerable.Range(0, 100);
            var result01 = Enumerable.Range(50, 100);
            var res = result0.Union(result01).ToList();
            #endregion
            #endregion
        }
    }
}
