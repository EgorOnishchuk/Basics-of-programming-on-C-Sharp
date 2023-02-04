int GetArrayComponent(string component)
{
    Console.WriteLine($"Введите {component}.");
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int length, int rangeMinNum, int rangeMaxNum)
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

int GetArrayEvenPositionElementsSum(int[] array)
{
    int length = array.Length;
    int sum = 0;

    for (int i = 1; i < length; i += 2)
    {
        sum += array[i];
    }

    return sum;
}

int length = GetArrayComponent("количество элементов массива");
int rangeMinNum = GetArrayComponent("минимальное число диапазона, в пределах которого будут создаваться случайные числа для массива");
int rangeMaxNum = GetArrayComponent("максимальное число диапазона, в пределах которого будут создаваться случайные числа для массива");
int[] array = CreateArray(length, rangeMinNum, rangeMaxNum);

PrintArrayElements(array);
Console.WriteLine($"Сумма элементов массива, стоящих на чётных позициях - {GetArrayEvenPositionElementsSum(array)}.");