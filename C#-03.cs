using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите два целых значения через запятую (например 7, 5):");
            int[] values = Console.ReadLine().Split(',').Select(s => Convert.ToInt32(s)).ToArray();

            int a = 7, b = 5;
            Console.WriteLine("a -> {0}; b -> {1}", a, b);
            Swap(ref a, ref b);
            Console.WriteLine("a -> {0}; b -> {1}", a, b);
        }

        public static void Swap(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;

        }
    }
}
