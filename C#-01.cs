using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Здравствуйте, не могли бы вы запонилть анкету?");

            Console.WriteLine("Ваше имя?");
            string name = Console.ReadLine();

            Console.WriteLine("Ваша фамилия?");
            string surname = Console.ReadLine();

            Console.WriteLine("Ваш возраст ?");
            string age = Console.ReadLine();

            Console.WriteLine("Ваш рост?");
            string height = Console.ReadLine();

            Console.WriteLine("Ваш вес ?");
            string weight = Console.ReadLine();

            Console.WriteLine(name + " " + surname + ": " + age + " лет, " + height + " см., " + weight + " кг.");
           
        }
    }
}
