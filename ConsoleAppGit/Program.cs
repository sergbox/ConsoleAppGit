using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double result = Math.Sin(x) + Math.Cos(x);
            Console.WriteLine("Результат вычислений: " + result);
            Console.ReadKey();
        }
    }
}

