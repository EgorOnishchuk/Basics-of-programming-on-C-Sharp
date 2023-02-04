int GetArrayComponent(string component)
{
    Console.WriteLine($"Введите {component}.");
    return int.Parse(Console.ReadLine()!);
}

double[] CreateArray(int length, int rangeMinNum, int rangeMaxNum)
{
    double[] array = new double[length];
    var randomNum = new Random();

    for (int i = 0; i < length; i++)
    {
        array[i] = randomNum.NextDouble() * (rangeMaxNum - rangeMinNum) + rangeMinNum;
        array[i] = Math.Round(array[i], 2);
    }

    return array;
}

void PrintArrayElements(double[] array)
{
    Console.WriteLine($"Элементы массива - {string.Join(", ", array)}");
}

double GetArrayNum(double[] array, bool max = true)
{
    int length = array.Length;
    double number = array[0];

    for (int i = 1; i < length; i++)
    {
        if ((array[i] > number && max) || (array[i] < number && !max))
        {
            number = array[i];
        }
    }

    return number;
}

int length = GetArrayComponent("количество элементов массива");
int rangeMinNum = GetArrayComponent("минимальное число диапазона, в рамках которого будут создаваться случайные числа для массива");
int rangeMaxNum = GetArrayComponent("максимальное число диапазона, в рамках которого будут создаваться случайные числа для массива");
double[] array = CreateArray(length, rangeMinNum, rangeMaxNum);

PrintArrayElements(array);
Console.WriteLine($"Разность максимального и минимального элементов массива - {GetArrayNum(array) - GetArrayNum(array, false):f}.");
Console.WriteLine("Числа округляются до 2 знаков после запятой.");