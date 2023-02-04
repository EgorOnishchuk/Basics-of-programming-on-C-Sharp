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

void PrintArrayElements(double[,] array, string version)
{
    Console.WriteLine($"Элементы массива {version}");

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

void SortArrayRowsElementsDescending(double[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int maxNumIndex;
    double temporary;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns - 1; j++)
        {
            maxNumIndex = j;

            for (int k = j + 1; k < columns; k++)
            {
                if (array[i, k] > array[i, maxNumIndex])
                {
                    maxNumIndex = k;
                }
            }

            temporary = array[i, j];
            array[i, j] = array[i, maxNumIndex];
            array[i, maxNumIndex] = temporary;
        }
    }
}


int rows = GetArrayComponent("количество строк массива");
int columns = GetArrayComponent("количество столбцов массива");
int rangeMinNum = GetArrayComponent("минимальное число диапазона, в пределах которого будут создаваться псевдослучайные числа для массива");
int rangeMaxNum = GetArrayComponent("максимальное число диапазона, в пределах которого будут создаваться псевдослучайные числа для массива");
int fractionalPart = GetArrayComponent("количество знаков после запятой в числах");

double[,] array = CreateArray(rows, columns, rangeMinNum, rangeMaxNum, fractionalPart);
PrintArrayElements(array, "до упорядочивания строк по убыванию");
SortArrayRowsElementsDescending(array);
PrintArrayElements(array, "после упорядочивания строк по убыванию");