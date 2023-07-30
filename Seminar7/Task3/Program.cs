// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

void PrintNewMassive(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i+=2)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            if(i % 2 == 0 & j % 2 == 0)
            {
            massive[i, j] = Convert.ToInt32(Math.Pow(massive[i, j], 2));
            Console.Write($"{massive[i,j]} ");
            }
        }
        // Console.WriteLine();
    }
}

void PrintDoubleMassive(int[,] massive)
{
     for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] DoDoubleMassive(int rows, int columns)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
          result[i, j] = i + j;  
        }
    }
    return result;
}

int GetInfo(string text)
{
    Console.Write(text);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

int rows = GetInfo("Введите количество строк: ");
int columns = GetInfo("Введите количество столбцов: ");
int[,] massive = DoDoubleMassive(rows, columns);
PrintDoubleMassive(massive);
Console.WriteLine();
PrintNewMassive(massive);
