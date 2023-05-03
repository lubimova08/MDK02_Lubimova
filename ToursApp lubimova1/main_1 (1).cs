/*Любимова Валерия
22ис-21
20 вариант*/
using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите значение u: ");
            double u = double.Parse(Console.ReadLine());
            Console.Write("Введите значение b начальное: ");
            double bStart = double.Parse(Console.ReadLine());
            Console.Write("Введите значение b конечное: ");
            double bEnd = double.Parse(Console.ReadLine());
            Console.Write("Введите значение Delta b: ");
            double deltaB = double.Parse(Console.ReadLine());
            double S = 0;
            for (double b = bStart; b <= bEnd; b += deltaB)
            {
                double cosU = Math.Cos(u);
                double sqrtTerm = Math.Sqrt(Math.Pow(u, 2) + (b * Math.Cos(b)));
                double sinB = Math.Sin(b);
                S += (x * cosU) - (sqrtTerm / sinB);
                
            }
            Console.WriteLine($"Значение выражения S: {S}");
            
        }
        
    }
}