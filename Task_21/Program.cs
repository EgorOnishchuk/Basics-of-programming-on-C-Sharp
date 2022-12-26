double GetPointCoordinate (string number, string axis)
{   
    Console.WriteLine ($"Введите координату точки {number} на оси {axis}.");
    return double.Parse(Console.ReadLine()!);
}

double GetDistanceBetweenPoints (double xA, double yA, double zA, double xB, double yB, double zB)
{
    return Math.Sqrt((xB - xA) * (xB - xA) + (yB - yA) * (yB - yA) + (zB - zA) * (zB - zA));
}

double xA = GetPointCoordinate ("A", "x");
double yA = GetPointCoordinate ("A", "y");
double zA = GetPointCoordinate ("A", "z");
double xB = GetPointCoordinate ("B", "x");
double yB = GetPointCoordinate ("B", "y");
double zB = GetPointCoordinate ("B", "z");
double distanceBetweenPoints = GetDistanceBetweenPoints (xA, yA, zA, xB, yB, zB);
Console.WriteLine ($"Расстояние между двумя точками в пространстве - {distanceBetweenPoints:f}. Если введённые координаты имеют больше двух знаков после запятой, результат округляется до двух знаков после запятой.");