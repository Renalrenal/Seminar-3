//  Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


int ReadInt(string message)
{
    System.Console.Write($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}

int a = ReadInt("Введите число");

for(int i = 1; i <= a; i++)
{
    double result = Math.Pow(i,2);
System.Console.Write($"({result}), ");
}