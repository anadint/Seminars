// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

void DefRes(int num)
{
    string temp = "";
    while (num > 0)
    {
        temp = (num % 2).ToString() + temp;
        num = num / 2;
    }
    Console.WriteLine(temp);
}

int GetInfo(string text)
{
    Console.Write(text);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

int num = GetInfo("Введите число: ");
DefRes(num);