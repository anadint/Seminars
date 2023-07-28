// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int FindCount (int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] >= 10 && array[i]<= 99)
        result += 1;
    }
    return result;
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
int[] array = GenArray(length, min, max);
int count = FindCount(array);
Console.Write("[" + string.Join(",", array) + "] -> " + FindCount(array));
