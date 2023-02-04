int GetArrayComponent(string component)
{
    Console.WriteLine($"Введите {component}.");
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int elementsNumber, int rangeMinimalNumber, int rangeMaximalNumber)
{
    int[] array = new int[elementsNumber];
    int length = array.Length;
    int randomNumber;

    for (int i = 0; i < length; i++)
    {
        randomNumber = new Random().Next(rangeMinimalNumber, rangeMaximalNumber + 1);
        array[i] = randomNumber;
    }

    return array;
}

void PrintArray(int[] array)
{
    int length = array.Length;

    for (int i = 0; i < length; i++)
    {
        if (i + 1 == length)
        {
            Console.Write(array[i]);
        }
        else
        {
            Console.Write($"{array[i]}, ");
        }
    }
}

int elementsNumber = GetArrayComponent("количество элементов массива");
int rangeMinimalNumber = GetArrayComponent("минимальное число диапазона, в пределах которого будут создаваться случайные числа для массива");
int rangeMaximalNumber = GetArrayComponent("максимальное число диапазона, в пределах которого будут создаваться случайные числа для массива");
PrintArray(CreateArray(elementsNumber, rangeMinimalNumber, rangeMaximalNumber));