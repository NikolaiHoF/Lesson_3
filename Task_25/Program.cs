// Задача №25: Напишите цикл, который принимает на вход два числа (А и B) и возводит число А в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int array(int numA, int numB)
{
    int res = 1;
    for (int i = 1; i <= numB; i++)
    {
        res = res * numA;
    }
    return res;
}

Console.Write("Введите число А: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int cikl = array(numA, numB);
Console.WriteLine("Ответ: " + cikl);