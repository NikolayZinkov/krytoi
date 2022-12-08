﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
double [,] array = new double[3, 4];
createArray(array);
Console.WriteLine();

void createArray (double [,] arr)
{
   for (int i = 0; i < arr.GetLength(0); i++)
   {
       for (int j = 0; j < arr.GetLength(1); j++)
       {
        arr[i,j] =  Convert.ToDouble(new Random().Next(-1000 , 1000));
        Console.Write($"{arr[i,j]} ");
       }
       Console.WriteLine();
   }
}