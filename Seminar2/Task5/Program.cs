// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

void Result ( int arg1, int arg2)
{
    if (arg1*arg1 == arg2 || arg2*arg2 == arg1)
    {
        Console.WriteLine($"{arg1},{arg2} -> да");
    }
    else
    {
        Console.WriteLine($"{arg1},{arg2} -> нет");
    }
}

Console.Write("Введите первое число: ");
int numA = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int numB = int.Parse(Console.ReadLine());

Result(numA, numB);


