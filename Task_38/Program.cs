// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] newArray(int a)
{
    int[] array = new int[a];
    Console.Write("[ ");
    for (int i = 0; i < a; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("]");
    return array;
}

Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] array1 = newArray(a);
int max = array1[0];
for (int i = 0; i < array1.Length; i++)
{
    if (max < array1[i]) max = array1[i];
}
int min = array1[0];
for (int i = 0; i < array1.Length; i++)
{
    if (min > array1[i]) min = array1[i];
}
int diff = max - min;

Console.WriteLine($"Максимальное значение = {max}. Минимальное значение = {min}. Разница между ними = {diff}.");