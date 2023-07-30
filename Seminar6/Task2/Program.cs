// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

void Check(int a, int b, int c)
{
    if (a + b > c && b + c > a && c + a > b)
    {
        Console.WriteLine("Такой треугольник может существовать");
    }
    else
    {
        Console.WriteLine("Такой треугольник НЕ может существовать");
    }
}

int GetInfo(string text)
{
    Console.Write(text);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

int a = GetInfo("Введите первое число: ");
int b = GetInfo("Введите второе число: ");
int c = GetInfo("Введите третье число: ");
Check(a, b, c);
