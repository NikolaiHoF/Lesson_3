// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите трехзначное число: ");

string a = Console.ReadLine();
int length = a.Length;
int b = Convert.ToInt32(a);
int c = 0;

if (length <= 2)
{
    Console.WriteLine("Третьей цифры нет, введите трехзначное число!");
}
else
{
    while (c < (length - 3))

    {
        b = b / 10;
        c++;
    }
    Console.WriteLine(b % 10);
}



