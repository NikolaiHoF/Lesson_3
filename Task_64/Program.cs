// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

string NaturalNumbers(int a, int n)
{
    if(a == n) return $"{n} ";
    return NaturalNumbers(a, n - 1) + n + " ";
}
Console.WriteLine(NaturalNumbers(4, 8));