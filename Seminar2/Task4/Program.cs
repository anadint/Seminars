// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно
// 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

double div1 = num % 7;
double div2 = num % 23;

if (div1 == 0 && div2 == 0)
{
    Console.WriteLine($"Число {num} кратно 7 и 23");
}
else
{
    Console.WriteLine($"Число {num} НЕ кратно 7 и 23");
}