int SummarizeNumberDigits (int number)
{
    int numberDigitsSummary = 0;
    while (number != 0)
    { 
        numberDigitsSummary += number % 10;
        number = number / 10;
    }
    return numberDigitsSummary;
}

Console.WriteLine ("Введите число.");
int number = int.Parse (Console.ReadLine ()!);
Console.WriteLine ($"Сумма цифр числа {number} - {SummarizeNumberDigits (number)}.");