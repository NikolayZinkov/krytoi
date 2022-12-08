// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine ("Введите число вводимое в степень: ");
int number = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine ("Введите степень числа: ");
int degree = Convert.ToInt32(Console.ReadLine ());
int count = 1;
int total = number;
while (count < degree)
{
    total = number * total;
    count++;
}
Console.WriteLine($"{number} в степени {degree} = {total}");
