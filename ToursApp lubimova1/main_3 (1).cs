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
            Console.Write("Введите значение a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите значение z: ");
            double z = double.Parse(Console.ReadLine());
            double T = -2.48;
            for (int i = 1; i <= z; i++)
            {
                double sinZ = Math.Sin(z);
                double cosZ = Math.Cos(z);
                double sqrtI = Math.Sqrt(Factorial(i));
                double numerator = Math.Pow(-1, i) * Math.Pow(sinZ, i) - (i * a);
                double denominator = Math.Pow(cosZ, i) + sqrtI * Math.Pow(x, i);
                T += numerator / denominator;
                
            }
            Console.WriteLine($"Значение выражения T: {T}");
            
        }
        static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
                
            }
            else
            {
                return n * Factorial(n - 1);
                
            }
            
        }
        
    }
}