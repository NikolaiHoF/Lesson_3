// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");

int a = Convert.ToInt32(Console.ReadLine());

    a = a/10;
    a = a%10;
    Console.Write("Второе число - "); Console.WriteLine(a);




