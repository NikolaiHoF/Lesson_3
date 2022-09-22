// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumElements(int M, int N)
{
    if (M > N) return 0;
    else return N + SumElements(M, N - 1);
}
Console.WriteLine(SumElements(1, 15));