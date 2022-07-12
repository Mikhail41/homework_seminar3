//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();

Console.WriteLine($"Эта программа проверяет, является введенное пятизначное число палиндромом или нет. ");

Console.WriteLine($"Введите число: ");
string? number = Console.ReadLine();

void Palindrom(string number)
{
    if (number[0] == number[4] || number[1] == number[3])
    {
        Console.WriteLine($"Ваше число: {number} -  это палиндром.");
    }
    else Console.WriteLine($"Ваше число: {number} - это не палиндром.");
}

if (number!.Length == 5)
{
    Palindrom(number);
}
else Console.WriteLine($"Введи правильное число");