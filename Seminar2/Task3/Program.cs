// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите первое число: ");
int numA = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int numB = int.Parse(Console.ReadLine());

double div = numA % numB;

if (div == 0)
{
    Console.Write($"Число {numB} кратно числу {numA}");
}
else
{
    Console.WriteLine($"Число {numB} НЕ кратно числу {numA}, остаток {div}");
}
