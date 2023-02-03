// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int GetValues(string valueNumber)
{
    Console.WriteLine($"Введите {valueNumber} число.");
    return int.Parse(Console.ReadLine()!);
}

bool IsNumNatural(double number)
{
    if (number <= 0)
    {
        return false;
    }
    
    return true;
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
while(!IsNumNatural(M))
{
    M = GetValues("первое");
}

int N = GetValues("второе");
while(!IsNumNatural(N))
{
    N = GetValues("второе");
}

Console.WriteLine($"Сумма натуральных чисел от {M} до {N} - {GetNaturalNumbersSum(M, N)}.");