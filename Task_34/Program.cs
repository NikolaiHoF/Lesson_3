// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] returnArray(int a)
{
    int[] array = new int[a];
    Console.Write("[ ");
    for (int i = 0; i < a; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("] ");
    return array;
}

Console.Write("Введите количество элементов массива: ");
int s = Convert.ToInt32(Console.ReadLine());
int[] array1 = returnArray(s);
int sum = 0;
for (int i = 0; i < array1.Length; i++)
{
    if (array1[i] % 2 == 0) sum++;
}
Console.WriteLine($"Число четных элементов в массиве - {sum}");