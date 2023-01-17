int GetRaisingNumberToPowerComponent (string component)
{
    Console.WriteLine ($"Введите {component} числа.");
    return int.Parse (Console.ReadLine()!);
}

int RaiseNumberToPower (int numberBase, int numberNaturalIndicator)
{
    int raisingNumberToPowerResult = numberBase;
    for (int i = 1; i < numberNaturalIndicator; i++)
    {
        raisingNumberToPowerResult *= numberBase; 
    }
    return raisingNumberToPowerResult;
}

int A = GetRaisingNumberToPowerComponent ("основание");
int B = GetRaisingNumberToPowerComponent ("натуральный показатель");

Console.WriteLine ($"Результат возведения числа {A} в степень {B} - {RaiseNumberToPower (numberBase: A, numberNaturalIndicator: B)}.");