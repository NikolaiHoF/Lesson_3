// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int numN = Convert.ToInt32(Console.ReadLine());

int sumNumb(int numN)
{
    int count = Convert.ToString(numN).Length;
    int a = 0;
    int res = 0;
    for (int i = 0; i < count; i++)
    {
        a = numN - numN % 10;
        res = res + (numN - a);
        numN = numN / 10;
    }
    return res;
}

int sumNum = sumNumb(numN);
Console.WriteLine("Сумма всех цифр в числе: " + sumNum);