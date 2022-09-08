// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] newArray(int a)
{
    int[] array = new int[a];
    Console.Write("[ ");
    for (int i = 0; i < a; i++)
    {
        array[i] = new Random().Next(-10, 10);
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("]");
    return array;
}

Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] array1 = newArray(a);
int sum = 0;
for (int i = 0; i < array1.Length; i++)
{
    if (i % 2 == 1) sum = sum + array1[i];
}
Console.WriteLine($"Сумма нечетных позиций элементов - {sum}");