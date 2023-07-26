// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y)

string CoordinateRange(int quarter)
{
    string xRange = "";
    string yRange = "";
    if (quarter == 1)
    {
        xRange = "x > 0";
        yRange = " y > 0";
    }
    if (quarter == 2)
    {
        xRange = "x < 0";
        yRange = " y > 0";
    }
    if (quarter == 3)
    {
        xRange = "x < 0";
        yRange = " y < 0";
    } 
    if (quarter == 4)
    {
        xRange = "x > 0";
        yRange = " y < 0";
    }
    return xRange +  yRange;
    
}

int GetInfo(string message)
{
    Console.Write(message);
    int numQuarter = Convert.ToInt32(Console.ReadLine());
    return numQuarter;

}

int quarter = GetInfo("Введите номер четверти: ");
Console.WriteLine($"Диапазон {CoordinateRange(quarter)}");
