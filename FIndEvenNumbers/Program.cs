Console.WriteLine("Введите число.");
int N = int.Parse(Console.ReadLine()!);

int i = 1;

while (i <= N)
{
    if (i % 2 == 0)
    {
        if (i + 1 >= N)
        {
            Console.Write($"{i}.");
        }
        else
        {
            Console.Write($"{i}, ");
        }
    }

    i++;
}