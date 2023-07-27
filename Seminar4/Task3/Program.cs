// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int FindFactorial(int num)
{
    int factorial = 1;
    while (num > 0)
    {
        factorial = factorial * num;
        num--;
    }
    return factorial;
}

int GetInfo(string text)
{
    Console.Write(text);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

int num = GetInfo("Введите число: ");
int factorial = FindFactorial(num);
Console.WriteLine(factorial);
