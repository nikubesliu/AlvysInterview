using System;
using System.Collections.Generic;

namespace AlvysInterview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 1, 2, 3 };
            var result = Helper.Map(list, x => x + 1);

            Console.WriteLine("Problem1");
            Console.WriteLine("-------------------------------------------");           
            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
            Console.WriteLine("Problem2");
            Console.WriteLine("-------------------------------------------");            
            var foldResult = Helper.Fold(list, 0, (sum, x) => sum + x);
            Console.WriteLine(foldResult);

            Console.WriteLine("Problem3");
            Console.WriteLine("-------------------------------------------");           
            var resultMap2 = Helper.Map2(list, x => x + 1);
            foreach (var item in resultMap2)
            {
                Console.Write($"{item} ");
            }

            Console.ReadKey();
        }
    }
}
