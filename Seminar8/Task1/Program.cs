// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

void PrintReversedArray(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == 0)
            {
                temp = array[i, j];
                array[i, j] = array[array.GetLength(0) - 1 - i, j];
                array[array.GetLength(0) - 1 - i, j] = temp;                
            }
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void PrintArray(int[,] array)
{
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] FillArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
          result[i, j] = new Random().Next(minValue, maxValue + 1);  
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
int[,] array = FillArray(rows, columns, 0, 9);
PrintArray(array);
Console.WriteLine();
PrintReversedArray(array);
