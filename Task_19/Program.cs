// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
try
{
    Console.Write("Введите пятизначное число: ");
    int palind = Int32.Parse(Console.ReadLine());
    int num = palind;
    int res = 0;

    while (num > 0) 
    {
        res = res * 10;
        res = res + num % 10;
        num = num / 10;
    }
    if (palind == res)
    {
        Console.WriteLine($"Число {palind} является палиндромом.");
    }
    else
    {
        Console.WriteLine($"Число {palind} не является палиндромом.");
    }
}

catch 
{
    Console.WriteLine("Вы ввели не числа или не пятизначное число");
}