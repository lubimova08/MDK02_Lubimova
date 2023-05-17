/*Любимова Валерия
22ИС-21
Вариант 20
В заданной матрице найти: сумму минимального и максимального элементов; количество отрицательных элементов, стоящих на чётных позициях. 
Обратить внимание на то, что индексация считается с нуля, а позиции – с единицы.*/
using System;
class HelloWorld {
  static void Main() {
    int[,] matrix = {
        { 5, -2, 8 },
        { 3, 0, -4 },
        { -1, 7, 2 }
        
    };
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    int min = matrix[0, 0];
    int max = matrix[0, 0];
    int negCount = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            int current = matrix[i, j];
            if (current < min)
            {
                min = current;
                
            }
            if (current > max)
            {
                max = current;
                
            }
            if (current < 0 && j % 2 == 0)
            {
                negCount++;
                
            }
            
        }
        
    }
    Console.WriteLine("Сумма минимального и максимального элементов: " + (min + max));
    Console.WriteLine("Количество отрицательных элементов, стоящих на четных позициях: " + negCount);
      
  }
}