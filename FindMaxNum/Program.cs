Console.WriteLine("Введите первое число.");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число.");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите третье число.");
int c = int.Parse(Console.ReadLine()!);

int maximum = a;

if (b > maximum)
{
    maximum = b;
}

if (c > maximum)
{
    maximum = c;
}

Console.WriteLine($"Максимальное число - {maximum}.");