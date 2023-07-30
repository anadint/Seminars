// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Мансур Рустэмович: Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

void MainDiagonal(int[,] massive)
{
    int sum = 0;
    int size = massive.GetLength(0);
    if(massive.GetLength(1) < massive.GetLength(0))
    {
        size = massive.GetLength(1);
    }
    for (int i = 0; i < size - 1; i++)
    {
        Console.Write($"{massive[i, i]} + ");
        sum += massive[i, i];
    }
    sum += massive[size - 1, size - 1];
    Console.WriteLine($"{massive[size - 1, size - 1]} = {sum }");
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
Console.Write("Сумма главной диагонали: ");
MainDiagonal(massive);
