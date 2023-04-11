// \Напишите программу, которая по заданному номеру четверти, показывает 
// диапазон возможных координат точек в этой четверти (x и y).

int ReadInt(string message)
{
    System.Console.Write($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}

string GetRange(int quarter)
{
    if (quarter == 1)
    {
        return ("x > 0; y > 0");

    }
    if (quarter == 2)
    {
        return ("x > 0; y < 0");

    }
    if (quarter == 3)
    {
        return ("x < 0;y < 0");

    }
    return ("x > 0;y < 0");
}

bool ValidateXY(int quarter)
{
    if (quarter < 1 || quarter > 4)
    {
        System.Console.WriteLine("Введите в какой четверти хотите узнать значениe");
        return false;
    }
    return true;
}

int result = ReadInt("Введите значение: ");
if (ValidateXY(result))
{
    string name = GetRange(result);

    System.Console.WriteLine($"Диапазон : {name}");

}
