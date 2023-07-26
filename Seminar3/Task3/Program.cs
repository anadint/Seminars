// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

double Length(int xA, int yA, int xB, int yB)
{
    double distance = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2));
    return distance;
}

int GetInfo(string message)
{
    Console.Write(message);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;

}

int xPointA = GetInfo("Введите координату X точки А: ");
int yPointA = GetInfo("Введите координату Y точки А: ");
int xPointB = GetInfo("Введите координату X точки B: ");
int yPointB = GetInfo("Введите координату Y точки B: ");
Console.WriteLine($"Расстояние между точками А и В равно {Length(xPointA, yPointA,xPointB, yPointB)}");
