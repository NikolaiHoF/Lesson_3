// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

string returnPOW()
{
    Console.WriteLine("Введите число, для составления таблицы кубов ");
    int powNumb = Convert.ToInt32(Console.ReadLine());
    int start = 1;
    List<int> answer = new List<int> {};
    while (start <= powNumb)
    {
        int numb = Convert.ToInt32(Math.Pow(start, 3));
        start = start + 1;
        answer.Add(numb);
    }
    string answer1 = string.Join(", ", answer.ToArray());
    return answer1;
}

try
{
Console.WriteLine(returnPOW());
}

catch
{
Console.WriteLine("Вы ввели не число");  
}