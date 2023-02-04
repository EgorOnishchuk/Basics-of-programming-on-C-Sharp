// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int GetFunctionArgument(string argumentNumber)
{
    Console.WriteLine($"Введите {argumentNumber} неотрицательное число.");
    return int.Parse(Console.ReadLine()!);
}

int CalculateAckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }

    if (m > 0 && n == 0)
    {
        return CalculateAckermannFunction(m - 1, 1);
    }

    return CalculateAckermannFunction(m - 1, CalculateAckermannFunction(m, n - 1));
}


int m = GetFunctionArgument("первое");
int n = GetFunctionArgument("второе");

Console.WriteLine($"Результат вычисления функции Аккермана - {CalculateAckermannFunction(m, n)}.");