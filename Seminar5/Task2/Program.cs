// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] GenArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    for (int i = 0; i < length - 1; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}

int[] GenReversArray (int []arr)
{
    int[] arrayNew = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        arrayNew[i] = arr[i] * -1;
    }
    return arrayNew;
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
int[] arrayNew = GenReversArray(array);
Console.Write("[" + string.Join(",", array) + "] -> ");
Console.WriteLine("[" + string.Join(",", arrayNew) + "]");

