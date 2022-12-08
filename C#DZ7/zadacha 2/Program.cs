// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

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
Console.WriteLine("Введите строку нужного элемента (нумерация с нуля)");
 int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец нужного элемента (нумерация с нуля)");
 int b = Convert.ToInt32(Console.ReadLine());
 if (a>3 | b>4)
    Console.WriteLine("Неверные координаты");
 else
 {
    object c = array.GetValue(a,b);
    Console.WriteLine(c);
 }