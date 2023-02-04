int GetArrayComponent(string component)
{
    Console.WriteLine($"Введите {component}.");
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int length, int rangeMinNum = 100, int rangeMaxNum = 999)
{
    int[] array = new int[length];
    var randomNum = new Random();

    for (int i = 0; i < length; i++)
    {
        array[i] = randomNum.Next(rangeMinNum, rangeMaxNum + 1);
    }

    return array;
}

void PrintArrayElements(int[] array)
{
    Console.WriteLine($"Элементы массива - {string.Join(", ", array)}");
}

int GetArrayEvenNumbers(int[] array)
{
    int length = array.Length;
    int evenNumbers = 0;

    for (int i = 0; i < length; i++)
    {
        if (array[i] % 2 == 0)
        {
            evenNumbers++;
        }
    }

    return evenNumbers;
}

int[] array = CreateArray(length: GetArrayComponent("количество элементов массива"));
PrintArrayElements(array);

Console.WriteLine($"Количество элементов массива с чётными значениями - {GetArrayEvenNumbers(array)}.");