// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру от 1 до 7 ");

int day = Convert.ToInt32(Console.ReadLine());

if (day > 5 & day < 8)
{
    Console.WriteLine("Это выходной день");
}

else if (day >= 1 & day < 6)
{
    Console.WriteLine("Это рабочий день");
} 

else
{
    Console.WriteLine("Вы ввели неверное число");
}