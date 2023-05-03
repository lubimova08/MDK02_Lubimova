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
            const int X = 5;
            const int Y = 3;
            const int Z = 7;
            int largerX, smallerZ, remainingValue;
            if (X > Z)
            {
                largerX = X;
                smallerZ = Z;
                
            }
            else
            {
                largerX = Z;
                smallerZ = X;
                
            }
            remainingValue = Y;
            Console.WriteLine($"Значение большего X: {largerX}");
            Console.WriteLine($"Значение меньшего Z: {smallerZ}");
            Console.WriteLine($"Значение Y: {remainingValue}");
            
        }
        
    }
}