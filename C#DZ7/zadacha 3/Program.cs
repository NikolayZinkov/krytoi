// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int [,] array = new int[3, 4];
createArray(array);
Console.WriteLine();
changeArray(array);

void createArray (int [,] arr)
{
   for (int i = 0; i < arr.GetLength(0); i++)
   {
       for (int j = 0; j < arr.GetLength(1); j++)
       {
        arr[i,j] = new Random().Next(0 , 10);
        Console.Write($"{arr[i,j]} ");
       }
       Console.WriteLine();
   }
}

void changeArray (int [,] arr)
{
double average = 0;
int a = 0;
for (int j = 0; j < arr.GetLength(1); j++)
  {
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        average = average + array[i,j];
        a++;
    }
     Console.WriteLine(Math.Round(average/a , 2));
  }
}
