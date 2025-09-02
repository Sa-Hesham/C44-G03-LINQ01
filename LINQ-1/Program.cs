

using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;
using static LINQ_1.ListGenerator;


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
        }
    }
}
