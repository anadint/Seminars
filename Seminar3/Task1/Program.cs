// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int DefQuarter(int xPoint, int yPoint)
{
    if (xPoint > 0 & yPoint > 0) return 1;
    if (xPoint < 0 & yPoint > 0) return 2;
    if (xPoint < 0 & yPoint < 0) return 3;
    if (xPoint > 0 & yPoint < 0) return 4;
    return 0;
}

int GetInfo(string message)
{
    Console.Write(message);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;

}

int xPoint = GetInfo("Введите координату X: ");
int yPoint = GetInfo("Введите координату Y: ");
Console.WriteLine($"Это {DefQuarter(xPoint, yPoint)} четверть!");