int GetArrayComponent(string component)
{
    Console.WriteLine($"Введите {component}.");
    return int.Parse(Console.ReadLine()!);
}

int[,] CreateArray(int rows, int columns, int rangeMinNum, int rangeMaxNum)
{
    int[,] array = new int[rows, columns];
    Random randomNum = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = randomNum.Next(rangeMinNum, rangeMaxNum + 1);
        }
    }

    return array;
}

void PrintArrayElements(int[,] array)
{
    Console.WriteLine("Элементы массива");

    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (j + 1 == columns)
            {
                Console.WriteLine(array[i, j]);
            }
            else
            {
                Console.Write($"{array[i, j]}, ");
            }
        }
    }
}

double[] GetArrayArithmeticalMeans(int[,] array)
{
    double rows = array.GetLength(0);
    int columns = array.GetLength(1);
    double summary = 0;
    double[] arithmeticalMeans = new double[columns];

    for (int i = 0; i < columns; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            summary += array[j, i];
        }
        arithmeticalMeans[i] = summary / rows;
        summary = 0;
    }

    return arithmeticalMeans;
}

void PrintArithmeticalMeans(double[] arithmeticalMeans)
{
    Console.WriteLine($"Средние арифметические элементов столбцов массива - {string.Join(", ", arithmeticalMeans)}.");
}


int rows = GetArrayComponent("количество строк массива");
int columns = GetArrayComponent("количество столбцов массива");
int rangeMinNum = GetArrayComponent("минимальное число диапазона, в пределах которого будут создаваться псевдослучайные числа для массива");
int rangeMaxNum = GetArrayComponent("максимальное число диапазона, в пределах которого будут создаваться псевдослучайные числа для массива");

int[,] array = CreateArray(rows, columns, rangeMinNum, rangeMaxNum);
PrintArrayElements(array);

double[] arithmeticalMeans = GetArrayArithmeticalMeans(array);
PrintArithmeticalMeans(arithmeticalMeans);