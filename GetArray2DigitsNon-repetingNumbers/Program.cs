int GetArrayComponent(string component)
{
    Console.WriteLine($"Введите {component}.");
    return int.Parse(Console.ReadLine()!);
}

int[,,] CreateArray(int length, int width, int height)
{
    int[,,] array = new int[length, width, height];
    return array;
}

bool FindNumInArray(int[,,] array, int number)
{
    int length = array.GetLength(0);
    int width = array.GetLength(1);
    int heigth = array.GetLength(2);
    int count = 0;

    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < width; j++)
        {
            for (int k = 0; k < heigth; k++)
            {
                if (array[i, j, k] == number)
                {
                    count++;
                }
            }
        }
    }

    if (count > 1)
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool FillArray(int[,,] array, int rangeMinNum = 10, int rangeMaxNum = 99)
{   
    int length = array.GetLength(0);
    int width = array.GetLength(1);
    int height = array.GetLength(2);
    int elementsNumber = length * width * height;

    if (elementsNumber > 90)
    {
        return false;
    }

    Random randomNum = new Random();

    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < width; j++)
        {
            for (int k = 0; k < height; k++)
            {
                array[i, j, k] = randomNum.Next(rangeMinNum, rangeMaxNum + 1);

                while (FindNumInArray(array, array[i, j, k]))
                {
                    array[i, j, k] = randomNum.Next(rangeMinNum, rangeMaxNum + 1); 
                }
            }
        }
    }

    return true;
}

void PrintArrayElements(int[,,] array)
{    
    Console.WriteLine("Элементы массива");

    int length = array.GetLength(0);
    int width = array.GetLength(1);
    int heigth = array.GetLength(2);

    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < width; j++)
        {
            for (int k = 0; k < heigth; k++)
            {
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k}), ");
            }
        }
    }
}


int length = GetArrayComponent("длину массива");
int width = GetArrayComponent("ширину массива");
int height = GetArrayComponent("высоту массива");
int[,,] array = CreateArray(length, width, height);

if (FillArray(array))
{
    PrintArrayElements(array);
}
else
{
    Console.WriteLine("Невозможно создать массив неповторяющихся двузначных чисел, так как их больше 90.");
}