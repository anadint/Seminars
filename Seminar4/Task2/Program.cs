// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

string GetInfo(string text)
{
    Console.Write(text);
    return Console.ReadLine();
}

string num = GetInfo("Введите число: ");
int length = num.Length;
Console.WriteLine(length);
