// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

bool SearchNum(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] == num || array[i] == -num)
            return true;
    return false;
}

int[] GenArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];

    for (int i = 0; i < length - 1; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}


int GetInfo(string text)
{
    Console.Write(text);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

int length = GetInfo("Введите длину массива: ");
int min = GetInfo("Введите начальное значение диапазона: ");
int max = GetInfo("Введите конечное значение диапазона: ");
int num = GetInfo("Введите заданное число: ");
int[] array = GenArray(length, min, max);
Console.Write(num + "; массив [" + string.Join(",", array) + "] -> ");
if(SearchNum(array, num)) Console.Write("да");
else Console.Write("нет");