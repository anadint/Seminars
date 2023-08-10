﻿// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

int[,] DeleteCrossRawColumn(int[,] array)
{
    int minI = 0;
    int minJ = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] < array[minI, minJ])
            {
                minI = i;
                minJ = j;
            }
        }
    }
    Console.WriteLine($"Минимальное число {array[minI, minJ]} располагается по адресу [{minI}, {minJ}]");
    int countI = 0;
    int countJ = 0;
    int[,] result = new int[array.GetLength(0)-1, array.GetLength(1)-1];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        countJ = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(j == minJ)
            {
                countJ = 1;
                continue;
            }
            result[i - countI, j - countJ] = array[i, j];
        }
        if(i == minI)
        {
            countI = 1;
            continue;
        }
    }
    return result;
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
int[,] array2 = DeleteCrossRawColumn(array);
PrintArray(array2);

