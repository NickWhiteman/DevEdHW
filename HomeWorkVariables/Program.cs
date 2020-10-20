using System;

//Условие : Пользователь вводит 2 числа (A и B). Выведите в консоль решение (5 * A + Math.Pow(B, 2)) / (B - A)

namespace HomeWorkVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число в переменную A");
            double A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число в переменную B");
            double B = Convert.ToInt32(Console.ReadLine());

            double Result = (5 * A + Math.Pow(B, 2)) / (B - A);

            Console.WriteLine($"Результат решения : (5 * A + Math.Pow(B, 2)) / (B - A) = {Result}");
        }
    }
}
