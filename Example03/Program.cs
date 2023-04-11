// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21


int ReadInt(string message)
{
    System.Console.Write($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}

int ax = ReadInt("Введите значения Х1:");
int bx = ReadInt("Введите значения Х2:");
int ay = ReadInt("Введите значения Y1:");
int by = ReadInt("Введите значение Y2:");

int cordx = (ax - ay);
int cordy = (bx - by);
double result = Math.Sqrt(Math.Pow(cordx, 2) + Math.Pow(cordy, 2));


System.Console.WriteLine($"Результат: {result:f3}");