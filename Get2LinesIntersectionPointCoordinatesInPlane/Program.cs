double GetEquationComponent(string component)
{
    Console.WriteLine($"Введите {component}.");
    return double.Parse(Console.ReadLine()!);
}

void Get2LinesIntersectionPointCoordinatesInPlane(double k1, double b1, double k2, double b2)
{
    if (k1 == k2 && b1 == b2)
    {
        Console.WriteLine("Существует бесконечное количество координат, так как прямые совпадают.");
    }
    else if (k1 == k2 && b1 != b2)
    {
        Console.WriteLine("Точки пересечения не существует, так как прямые параллельны.");
    }
    else
    {
        double xCoordinate = (b1 - b2) / (k2 - k1);
        double yCoordinate = k2 * xCoordinate + b2;
        Console.WriteLine($"Координаты точки пересечения двух прямых - {xCoordinate:f}, {yCoordinate:f}. В случае, если числа имеют более 2 знаков после запятой, они округляются до 2 знаков после запятой.");
    }
}

double k1 = GetEquationComponent("k1");
double b1 = GetEquationComponent("b1");
double k2 = GetEquationComponent("k2");
double b2 = GetEquationComponent("b2");

Get2LinesIntersectionPointCoordinatesInPlane(k1, b1, k2, b2);