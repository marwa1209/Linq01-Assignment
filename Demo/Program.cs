namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region What Is Linq
            ///Linq => Language Integrated Query
            ///Linq +40 Extention Methods
            ///Extention Methods For All Collection That Implement "IEnumrable" Interface 
            ///Named As Linq Operators Existed At Class Enumrable
            ///Categorized Into 13 Categorey
            
            List<int> Numbers = new List<int>() { 1, 2, 5, 6, 7, 9, 12, 14, 15, 19 };
            List<int> OddNumbers = Numbers.Where(x => x %2==1).ToList();
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
                             where N %2==1
                             select N;
            foreach (var number in oddNumbers) { Console.WriteLine(number); }; 
            //must begin with from and end with select or groupBy
            #endregion

            #endregion
        }
    }
}
