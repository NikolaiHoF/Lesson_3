// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void array1(int[] number)
{
    int length = number.Length;
    int index = 0;
    while (index < length)
    {
        number[index] = new Random().Next(1, 100);
        index++;
    }
}

void array2(int[] count)
{
    int count2 = count.Length;
    int pos = 0;
    while (pos < count2)
    {
        Console.WriteLine(count[pos]);
        pos++;
    }
}
int[] array3 = new int[8];

array1(array3);
array2(array3);