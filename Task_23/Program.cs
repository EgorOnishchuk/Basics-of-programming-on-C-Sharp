void PrintNumbersCubesFrom1ToN (int number)
{   
    int numberCube;
    int i = 1;
    while (i <= number)
    {   
        numberCube = i * i * i;
        if (i == number)
        {   
            Console.WriteLine ($"{numberCube}.");
        }
        else 
        {   
            Console.Write ($"{numberCube}, ");
        }
        i++;
    }
}

Console.WriteLine("Введите число.");
int N = int.Parse(Console.ReadLine()!);
PrintNumbersCubesFrom1ToN (N);