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

void PrintArrayElements(int[] array, string arrayKind)
{
    Console.WriteLine($"Элементы массива {arrayKind} - {string.Join(", ", array)}");
}

int[] GetNumbersPairsInArrayProduct(int[] array)
{
    int length = array.Length;
    int numbersPairs = length / 2;
    int numbersProduct;

    if (length % 2 == 1)
    {
        int[] arrayForNumbersProduct = new int[numbersPairs + 1];

        for (int i = 0; i < numbersPairs; i++)
        {
            numbersProduct = array[i] * array[length - 1 - i];
            arrayForNumbersProduct[i] = numbersProduct;
        }

        arrayForNumbersProduct[numbersPairs] = array[numbersPairs];
        return arrayForNumbersProduct;
    }
    else
    {
        int[] arrayForNumbersProduct = new int[numbersPairs];

        for (int i = 0; i < numbersPairs; i++)
        {
            numbersProduct = array[i] * array[length - 1 - i];
            arrayForNumbersProduct[i] = numbersProduct;
        }

        return arrayForNumbersProduct;
    }
}

int length = GetArrayComponent("количество элементов массива");
int rangeMinNum = GetArrayComponent("минимальное число диапазона, в пределах которого будут создаваться случайные числа для массива");
int rangeMaxNum = GetArrayComponent("максимальное число диапазона, в пределах которого буду создаваться случайные числа для массива");
int[] array = CreateArray(length, rangeMinNum, rangeMaxNum);

PrintArrayElements(array, "с парами чисел");
int[] arrayForNumberProduct = GetNumbersPairsInArrayProduct(array);
PrintArrayElements(arrayForNumberProduct, "с произведением пар чисел");