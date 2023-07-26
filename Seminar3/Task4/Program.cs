// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

void DefSqr(int num)
{
    Console.Write($"{num} -> ");
    for (int i = 1; i < num; i++)
    {
        Console.Write(i * i + ", ");
    }
    Console.WriteLine(num * num + "."); 
}

int GetInfo(string message)
{
    Console.Write(message);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;

}

int num = GetInfo("Введите число: ");
DefSqr(num);
