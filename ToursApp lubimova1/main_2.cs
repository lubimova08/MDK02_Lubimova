/*Любимова Валерия
22ИС-21
20 вариант*/
using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите значение b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите значение n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите значение c: ");
            double c = double.Parse(Console.ReadLine());
            double k = 0;
            if (a * a * n > b)
            {
                k = a * a * n;
            }
            else if (b * b * n < b)
            {
                k = b * b * n;
            }
            else if (c * c * n == b)
            {
                k = c * c * n;
            }
            double z = (Math.Cos(a) - b * b) / Math.Pow(a + b * b, 1.0 / 3) + Math.Tan(k) - Math.Exp(Math.PI + k * k);
            Console.WriteLine($"Значение выражения Z: {z}");
        }
        
    }
}