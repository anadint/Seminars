// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] GenNewArray(int[] array)
{
    int[] arrayNew = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        arrayNew[i] = array[i];
    }
    return arrayNew;
}

int[] GenArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int[] array = GenArray(10, 1, 10);
int[] arrayNew = GenNewArray(array);
Console.WriteLine("[" + string.Join(",", array) + "] -> [" + string.Join(",", arrayNew) + "]");
