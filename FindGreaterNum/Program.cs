Console.WriteLine("Введите первое число.");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число.");
int b = int.Parse(Console.ReadLine()!);

if (a > b)
{
    Console.WriteLine($"Число {a} - большее, число {b} - меньшее.");
}
else
{
    Console.WriteLine($"Число {b} - большее, число {a} - меньшее.");
}