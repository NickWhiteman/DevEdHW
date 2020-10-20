using System;

//Условие: Пользователь вводит 3 числа (A, B и C). Выведите в консоль решение (значения X) линейное уравление стандартного вида, где A * X + B = C

namespace HomeWorkVariables3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Я решаю уравнение A * X + B = C");
            Console.WriteLine();
            Console.WriteLine("Введите значение переменной A");
            double A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение переменной B");
            double B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение переменной C");
            double C = Convert.ToInt32(Console.ReadLine());

            double X = (C - B) / A;

            Console.WriteLine($"Решение уравнения A * X + B = C  X = {X}");
        }
    }
}
