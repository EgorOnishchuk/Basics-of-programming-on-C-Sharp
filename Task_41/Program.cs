// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

double[] GetNumbers(int length)
{   
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"Введите {i + 1} число.");
        array[i] = double.Parse((Console.ReadLine()!));
        array[i] = Math.Round(array[i], 2);
    }
    return array;
}

void PrintNumbers(double[] array)
{
    Console.WriteLine($"Числа - {string.Join(", ", array)}. В случае, если числа имеют более 2 знаков после запятой, они округляются до 2 знаков после запятой.");
}

int GetNumbersGreaterThan0(double[] array)
{
    int length = array.Length;
    int numbersGreaterThan0 = 0;
    for (int i = 0; i < length; i++)
    {
        if (array[i] > 0)
        {
            numbersGreaterThan0++;
        }
    }
    return numbersGreaterThan0;
}

Console.WriteLine("Введите общее количество чисел.");
int M = int.Parse(Console.ReadLine()!);
double[] array = GetNumbers(M);
PrintNumbers(array);
Console.WriteLine($"Количество чисел больше 0 - {GetNumbersGreaterThan0(array)}.");