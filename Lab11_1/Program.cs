using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_1
{
    class Program
    {
        static void Main(string[] args)
        {         
            Console.WriteLine("Привет! Программа вычисляет корень линейного уравнения вида k*x+b=0");
            Console.Write("Введите коэффициент k:");
            double k = int.Parse(Console.ReadLine());
            Console.Write("Введите коэффициент b:");
            double b = int.Parse(Console.ReadLine());

            LinearEquation eq = new LinearEquation();
            eq.k = k;
            eq.b = b;
           
            if (double.IsInfinity(eq.Root()))
            {
                Console.WriteLine($"Корней нет");
                Console.ReadKey();
                return;
            }

            Console.WriteLine($"Корень: {eq.Root()}");
            Console.ReadKey();
        }
    }
}
