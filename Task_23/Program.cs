int GetNumberCube (int number)
{   
    return number * number * number;
}

int i = 1;
Console.WriteLine("Введите число.");
int N = int.Parse(Console.ReadLine()!);
while (i <= N)
{   
    int numberCube = GetNumberCube (i);
    if (i == N)
    {   
        Console.WriteLine ($"{numberCube}.");
    }
    else 
    {   
        Console.Write ($"{numberCube}, ");
    }
    i++;
}