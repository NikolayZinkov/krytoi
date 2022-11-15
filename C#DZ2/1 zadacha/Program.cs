// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write ("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine ());
 
 int a = num % 10;
 int i = (num - a) % 100;

int chislo = 0;
 int k = 10;
while (k <= i)
 {
k= k + 10;
chislo++;
 if (k > i)
{
break;
}
 }
Console.WriteLine (chislo);