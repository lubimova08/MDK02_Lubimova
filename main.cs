/*Любимова Валерия
22ИС-21
Вариант 20
Дан массив целых чисел. Сформировать массив этих же чисел, упорядоченных по убыванию, и массив индексов этих чисел в исходном массиве*/
using System;
class HelloWorld {
  static void Main() {
      {
    Console.Write("ВВедите размер массива n=");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] mas = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write("введите элемент массива mas[{0}]=", i);
        mas[i] = Convert.ToInt32(Console.ReadLine());
    }
    //Сортировака массива
    {
        Array.Sort(mas, (x, y) => y.CompareTo(x));
        Console.WriteLine(String.Join(", ", mas));
    }
    System.Console.ReadKey();
}
}
}