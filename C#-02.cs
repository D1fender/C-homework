using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Ваша ваш рост в (м.)?");
			double height = Double.Parse(Console.ReadLine());

			Console.WriteLine("Ваша ваш вес в (кг.)?");
			double weight = Double.Parse(Console.ReadLine());

			double index = weight / (height * height);

			Console.WriteLine("Ваш индекс массы тела: " + index.ToString("N2"));
		}
    }
}
