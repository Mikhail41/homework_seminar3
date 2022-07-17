//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();
Console.WriteLine($"Эта программа принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");

Console.WriteLine("Введите число больше 1 : ");
int number = Convert.ToInt32(Console.ReadLine());

int thirdDegree(int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.Write(i * i * i + " | ");
    }
    return n;
}
thirdDegree(number);