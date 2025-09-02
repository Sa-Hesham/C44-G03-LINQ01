

using System.Diagnostics.Metrics;
using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;
using System.Threading;
using System.Xml.Linq;
using static LINQ_1.ListGenerator;
using static System.Net.WebRequestMethods;


namespace LINQ_1
  
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators

            // 1.Find all products that are out of stock.


            //var result= Products.Where(p => p.UnitsInStock == 0);
            // foreach (var r in result) {

            //     Console.WriteLine(r);
            // }

            //2.Find all products that are in stock and cost more than 3.00 per unit.

            //var result = Products.Where(p => p.UnitPrice>3.00M);
            //foreach (var r in result)
            //{

            //    Console.WriteLine(r);
            //}

            //  3.Returns digits whose name is shorter than their value.
            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };


            //var res = Arr.Select((name, vlaue) => new { Name = name, Value = vlaue })
            //    .Where(p => p.Name.Length < p.Value);
            //foreach (var item in res) {

            //    Console.WriteLine(item);
            //}


            #endregion


            #region Ordering Operators
            //1.Sort a list of products by name

            //var sorting = Products.OrderBy(p => p.ProductName).ThenBy(p => p.UnitPrice).ToList();
            //foreach (var item in sorting) {

            //    Console.WriteLine(item);

            //}



            //2.Uses a custom comparer to do a case -insensitive sort of the words in an array.

            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr.OrderBy(x => x, StringComparer.OrdinalIgnoreCase);

            //foreach (var item in result)
            //{

            //    Console.WriteLine(item);
            //}



            //3. Sort a list of products by units in stock from highest to lowest.

            //var result02 = Products.OrderByDescending(p => p.UnitsInStock)
            //    ;

            //foreach (var item in result02)
            //{

            //    Console.WriteLine(item);
            //}



            //4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] Arr = {"zero", "one", "two", "three", "four", "File", "six", "seven", "eight", "nine"};

            //var result03 = Arr
            //    .OrderBy(word => word.Length)
            //    .ThenBy(word => word);

            //foreach (var item in result03)
            //{

            //    Console.WriteLine(item);
            //}



            //5. Sort first by-word length and then by a case-insensitive sort of the words in an array.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var rsult = Arr.OrderBy(word => word.Length)
            //    .ThenBy(word => word,StringComparer.OrdinalIgnoreCase);
            //foreach (var r in rsult) {
            //    Console.WriteLine(r);

            //}



            //6.Sort a list of products, first by category, and then by unit price, from highest to lowest.


            //var sort=Products.OrderByDescending(x=>x.Category) .ThenByDescending(x=>x.UnitPrice);
            //foreach (var item in sort) 
            //{
            //    Console.WriteLine(item);
            //}



            //7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var rsult = Arr.OrderByDescending(word => word.Length)
            //    .ThenByDescending(word => word, StringComparer.OrdinalIgnoreCase);
            //foreach (var r in rsult)
            //{
            //    Console.WriteLine(r);

            //}


            //8.Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            //var result= Arr.Where(word=>word.Length>1 &&  word[1] =='i')
            //    .Reverse();

            //foreach (var item in result) {
            //    Console.WriteLine(item);
            
            //}



            #endregion
        }

    }
}
