int GetNumberThirdDigit (int number)
{
    while (number > 999)
    {
        number = number / 10;
    }
    return number % 10;
}

Console.WriteLine("Введите число.");
int number = int.Parse(Console.ReadLine()!);
if (number < 100)
{
    Console.WriteLine($"У числа {number} нет третьей цифры.");
} 
else
{
    Console.WriteLine($"Третья цифра числа {number} - {GetNumberThirdDigit(number)}.");
}