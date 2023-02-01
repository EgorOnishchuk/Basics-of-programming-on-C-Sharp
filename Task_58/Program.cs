// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int GetMatrixComponent(string component)
{   
    Console.WriteLine($"Введите {component}.");
    return int.Parse(Console.ReadLine()!);
}

double[,] CreateMatrix(int rows, int columns, int rangeMinNum, int rangeMaxNum, int fractionalPart)
{
    double[,] matrix = new double[rows, columns];
    Random randomNum = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = Math.Round(randomNum.NextDouble() * (rangeMaxNum - rangeMinNum) + rangeMinNum, fractionalPart);
        }
    }

    return matrix;
}

void PrintMatrix(double[,] matrix, string version)
{   
    Console.WriteLine($"{version} матрица");

    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (j + 1 == columns)
            {
                Console.WriteLine(matrix[i, j]);
            }
            else
            {
                Console.Write($"{matrix[i, j]}, ");
            }
        }
    } 
}

bool Get2MatricesProduct(double[,] firstMatrix, double[,] secondMatrix, double[,] resultingMatrix, int fractionalPart)
{
    int firstMatrixColumns = firstMatrix.GetLength(1);
    int secondMatrixRows = secondMatrix.GetLength(0);

    if (firstMatrixColumns != secondMatrixRows)
    {
        return false;
    }
    else
    {
        int firstMatrixRows = firstMatrix.GetLength(0);
        int secondMatrixColumns = secondMatrix.GetLength(1);
        double summary = 0;

        for (int i = 0; i < firstMatrixRows; i++)
        {
            for (int j = 0; j < secondMatrixColumns; j++)
            {   
                for (int k = 0; k < firstMatrixRows; k++)
                {   
                    summary += Math.Round(firstMatrix[i, k] * secondMatrix[k, j], fractionalPart);
                }
                
                resultingMatrix[i, j] = summary;
            }
        }
    }

    return true;
}

int rows = GetMatrixComponent("количество строк первой матрицы");
int columns = GetMatrixComponent("количество столбцов первой матрицы");
int rangeMinNum = GetMatrixComponent("минимальное число диапазона, в пределах которого будут создаваться псевдослучайные числа для первой матрицы");
int rangeMaxNum = GetMatrixComponent("максимальное число диапазона, в пределах которого будут создаваться псевдослучайные числа для первой матрицы");
int fractionalPart = GetMatrixComponent("количество знаков после запятой в числах");
int firstMatrixRows = rows;

double[,] firstMatrix = CreateMatrix(rows, columns, rangeMinNum, rangeMaxNum, fractionalPart);
PrintMatrix(firstMatrix, "Первая");

rows = GetMatrixComponent("количество строк второй матрицы");
columns = GetMatrixComponent("количество столбцов второй матрицы");
rangeMinNum = GetMatrixComponent("минимальное число диапазона, в пределах которого будут создаваться псевдослучайные числа для второй матрицы");
rangeMaxNum = GetMatrixComponent("максимальное число диапазона, в пределах которого будут создаваться псевдослучайные числа для второй матрицы");
fractionalPart = GetMatrixComponent("количество знаков после запятой в числах");
int secondMatrixColumns = columns;

double[,] secondMatrix = CreateMatrix(rows, columns, rangeMinNum, rangeMaxNum, fractionalPart);
PrintMatrix(secondMatrix, "Вторая");

fractionalPart = GetMatrixComponent("количество знаков после запятой в результирующей матрице");
double[,] resultingMatrix = new double[firstMatrixRows, secondMatrixColumns];

if (Get2MatricesProduct(firstMatrix, secondMatrix, resultingMatrix, fractionalPart))
{
    PrintMatrix(resultingMatrix, "Результирующая");
}
else
{
    Console.WriteLine("Невозможно найти произведение матриц, так как количество столбцов первой матрицы не равно количеству строк второй матрицы.");
}