// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int GetFunctionArgument(string argumentNumber)
{
    Console.WriteLine($"Введите {argumentNumber} неотрицательное число.");
    return int.Parse(Console.ReadLine()!);
}

int CalculateAckermannFunction(int firstNumber, int secondNumber)
{
    if (firstNumber == 0)
    {
        return secondNumber + 1;
    }
     
    if (firstNumber > 0 && secondNumber == 0)
    {
        return CalculateAckermannFunction(firstNumber - 1, 1);
    }

    return CalculateAckermannFunction(firstNumber - 1, CalculateAckermannFunction(firstNumber, secondNumber - 1));
}


int m = GetFunctionArgument("первое");
int n = GetFunctionArgument("второе");

Console.WriteLine($"Результат вычисления функции Аккермана - {CalculateAckermannFunction(m, n)}.");