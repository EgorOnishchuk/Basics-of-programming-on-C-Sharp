// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

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


int m = GetArrayComponent("количество строк массива");
int n = GetArrayComponent("количество столбцов массива");
int rangeMinNum = GetArrayComponent("минимальное число диапазона, в пределах которого будут создаваться псевдослучайные числа для массива");
int rangeMaxNum = GetArrayComponent("максимальное число диапазона, в пределах которого будут создаваться псевдослучайные числа для массива");
int fractionalPart = GetArrayComponent("максимальное количество знаков после запятой в числах");

double[,] array = CreateArray(m, n, rangeMinNum, rangeMaxNum, fractionalPart);
PrintArrayElements(array);