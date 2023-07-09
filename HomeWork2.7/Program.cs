using System;

class HomeWork
{
    static void Main()
    {
        Console.WriteLine("Введите значение переменной x : ");
        float x = float.Parse(Console.ReadLine());
        Console.WriteLine("Введите значение переменной y : ");
        float y = float.Parse(Console.ReadLine());
        float result = (1 + (1 / x * x)) - (12 * x * x * y);
        Console.WriteLine("Результат : " + result);
        Console.ReadKey();
    }
}