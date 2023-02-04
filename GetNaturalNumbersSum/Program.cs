int GetValues(string valueNumber)
{
    Console.WriteLine($"Введите {valueNumber} число.");
    int number = int.Parse(Console.ReadLine()!);

    while (number <= 0)
    {
        Console.WriteLine($"Введите {valueNumber} число.");
        number = int.Parse(Console.ReadLine()!);
    }

    return number;
}

int GetNaturalNumbersSum(int rangeFirstNum, int rangeLastNum)
{
    if (rangeFirstNum > rangeLastNum)
    {
        return 0;
    }

    return rangeFirstNum + GetNaturalNumbersSum(rangeFirstNum + 1, rangeLastNum);
}


int M = GetValues("первое");

int N = GetValues("второе");

Console.WriteLine($"Сумма натуральных чисел от {M} до {N} - {GetNaturalNumbersSum(M, N)}.");