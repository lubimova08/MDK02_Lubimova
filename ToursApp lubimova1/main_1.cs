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
            Console.Write("Введите символ операции (a - abs(x), c - ceil(x), f - floor(x), s - sqrt(x)): ");
            char operation = Console.ReadKey().KeyChar;
            int result = 0;
            switch (operation)
            {
                case 'a':
                result = Math.Abs((int)operation);
                break;
                case 'c':
                result = (int)Math.Ceiling((double)operation);
                break;
                case 'f':
                result = (int)Math.Floor((double)operation);
                break;
                case 's':
                result = (int)Math.Sqrt((double)operation);
                break;
                default:
                Console.WriteLine("\nНекорректный символ операции.");
                return;
                
            }
            Console.WriteLine($"\nРезультат выполнения операции над порядковым номером символа: {result}");
        }

    }
}