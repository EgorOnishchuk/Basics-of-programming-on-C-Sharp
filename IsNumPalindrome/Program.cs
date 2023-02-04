string DefineIfNumberIsPalindrome(int number)
{
    if (number / 10000 == number % 10 && number / 1000 % 10 == number % 100 / 10)
    {
        return "является";
    }
    else
    {
        return "не является";
    }
}

Console.WriteLine("Введите число.");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Число {number} {DefineIfNumberIsPalindrome(number)} палиндромом.");