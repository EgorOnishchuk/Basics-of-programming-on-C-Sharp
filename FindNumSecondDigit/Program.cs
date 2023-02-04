int GetNumberSecondDigit(int number)
{
    return number % 100 / 10;
}

Console.WriteLine("Введите число.");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Вторая цифра трёхзначного числа {number} - {GetNumberSecondDigit(number)}.");