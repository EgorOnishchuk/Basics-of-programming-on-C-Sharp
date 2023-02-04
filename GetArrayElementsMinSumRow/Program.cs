int GetArrayComponent(string component)
{
    Console.WriteLine($"Введите {component}.");
    return int.Parse(Console.ReadLine()!);
}

double[,] CreateArray(int rows, int columns, int rangeMinNum, int rangeMaxNum, int fractionalPart)
{
    double[,] array = new double[rows, columns];
    Random randomNum = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round(randomNum.NextDouble() * (rangeMaxNum - rangeMinNum) + rangeMinNum, fractionalPart);
        }
    }

    return array;
}

void PrintArrayElements(double[,] array)
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

int FindArrayElementsMinSumRow(double[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    double summary = 0;
    double minSummary = 0;
    int row = 1;

    for (int i = 0; i < columns; i++)
    {
        minSummary += array[0, i];
    } 

    for (int i = 1; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            summary += array[i, j];
        }

        if (summary < minSummary)
        {
            minSummary = summary;
            row = i + 1;
        }
    }
    
    return row;
}


int rows = GetArrayComponent("количество строк массива");
int columns = GetArrayComponent("количество столбцов массива");
int rangeMinNum = GetArrayComponent("минимальное число диапазона, в пределах которого будут создаваться псевдослучайные числа для массива");
int rangeMaxNum = GetArrayComponent("максимальное число диапазона, в пределах которого будут создаваться псевдослучайные числа для массива");
int fractionalPart = GetArrayComponent("количество знаков после запятой в числах");

double[,] array = CreateArray(rows, columns, rangeMinNum, rangeMaxNum, fractionalPart);
PrintArrayElements(array);
Console.WriteLine($"Номер строки массива с наименьшей суммой элементов - {FindArrayElementsMinSumRow(array)}.");