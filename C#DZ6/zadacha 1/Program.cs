// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine ("Введите набор чисел");
string nums = Console.ReadLine();
string[] number = nums.Split(new char[]{' ', '.', ','}, StringSplitOptions.RemoveEmptyEntries);
int[] arr = number.Select(Int32.Parse).ToArray();
int total = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        total = total + arr[i];
    }
}
Console.WriteLine($"Сумма положительных чисел: {total}");