// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y)

string CoordinateRange(int quarter)
{
    if (quarter == 1) return "x > 0, y > 0";
    if (quarter == 2) return "x < 0, y > 0";
    if (quarter == 3) return "x < 0, y < 0";
    if (quarter == 4) return "x > 0, y < 0";
    return "";
    
}

int GetInfo(string message)
{
    Console.Write(message);
    int numQuarter = Convert.ToInt32(Console.ReadLine());
    return numQuarter;

}

int quarter = GetInfo("Введите номер четверти: ");
Console.WriteLine($"Диапазон {CoordinateRange(quarter)}");
