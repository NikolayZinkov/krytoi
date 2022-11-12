//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Write ("Введите 1 число:");
int num = Convert.ToInt32(Console.ReadLine ());
Console.Write ("Введите 2 число:");
int num1 = Convert.ToInt32(Console.ReadLine ());
Console.Write ("Введите 3 число:");
int num2 = Convert.ToInt32(Console.ReadLine ());

if (num > num1&num > num2 ) {
    Console.WriteLine ( $"Наибольшее число {num}");
}
else if (num1 > num&num1 > num2 ) {
    Console.WriteLine ( $"Наибольшее число {num1}");
}
else if (num2 > num1&num2 > num ) {
    Console.WriteLine ( $"Наибольшее число {num2}");
}