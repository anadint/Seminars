// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] FindSum(int[] array)
{
    int size = array.Length / 2;
    if(array.Length % 2 == 1) size++;
    int[] arrayNew = new int [size];
    for (int i = 0; i < array.Length / 2; i++)
    {
        arrayNew[i] = array[i] * array[array.Length - i - 1];
    }
    if(array.Length % 2 == 1) arrayNew [size -1] = array[array.Length / 2];
    return arrayNew;
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
int[] arrayNew = FindSum(array);
Console.Write("[" + string.Join(",", array) + "] -> [" + string.Join(",", arrayNew) + "]");