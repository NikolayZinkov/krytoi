// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number =Convert.ToInt32(Console.ReadLine());
int numberSum = Convert.ToString(number).Length;
int num = 0;
int sum = 0;
for (int i = 0 ; i < numberSum; i++)
{
    num = number % 10;
    number = number / 10;
    sum = sum + num;
}
Console.WriteLine(sum);
