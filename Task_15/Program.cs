void DetermineIfDayIsHoliday (int dayOfWeekNumber)
{
    if (dayOfWeekNumber < 1 || dayOfWeekNumber > 7)
    {
        Console.WriteLine($"Цифра {dayOfWeekNumber} не обозначает день недели.");
    } 
    else if (dayOfWeekNumber > 5 && dayOfWeekNumber < 8)
    {
        Console.WriteLine("День недели является выходным.");
    } 
    else
    {
        Console.WriteLine("День недели не является выходным.");
    } 
}
Console.WriteLine("Введите цифру, обозначающую день недели.");
int dayOfWeekNumber = int.Parse(Console.ReadLine()!);
DetermineIfDayIsHoliday(dayOfWeekNumber);