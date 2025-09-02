

using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using System.Text.RegularExpressions;
using System.Threading;
using System.Xml.Linq;
using static LINQ_1.ListGenerator;
using static System.Net.WebRequestMethods;
using static System.Runtime.InteropServices.JavaScript.JSType;


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




            #region Transformation Operators


            //1.Return a sequence of just the names of a list of products.
            //var producationName = Products.Select(p => p.ProductName);
            //foreach (var item in producationName)
            //{
            //    Console.WriteLine(item);
            //}


            //2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            //String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var result = words.Select(word => new { Uppercase = word.ToUpper(), Lowercase = word.ToLower() });
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"upper {item.Uppercase} | lower {item.Lowercase} ");
            //}

            // 3.Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.

            //var result = Products .Select(p => new{ p.ProductName,Price = p.UnitPrice, p.UnitsInStock });

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Name: {item.ProductName}, Price: {item.Price}, Stock: {item.UnitsInStock}");
            //}



            // 4.Determine if the value of int in an array matches their position in the array.
            // int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Select((value, index) => new{  Value = value,  Index = index, Match = value == index});

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Value = {item.Value}, Index = {item.Index}, Match = {item.Match}");
            //}


            // 5.Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 }
            //;
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var res = from a in numbersA
            //          from b in numbersB
            //          where a < b
            //          select new { A = a, B = b };
            //foreach(  var item in res)
            //{
            //    Console.WriteLine($"{item.A} is less than  {item.B}");
            //}


            //6.Select all orders where the order total is less than 500.00.

            //var result = from o in orders
            //             where o.Total<500.00m
            //             select o;

            //foreach (var i in orders) {
            //    Console.WriteLine(i );

            //}


            //7.Select all orders where the order was made in 1998 or later.


            //var res = orders.Where(o => o.OrderDate.Year >= 1998);
            //foreach (var i in res)
            //{

            //    Console.WriteLine(i);


            //}




            #endregion
        }

    }
}
