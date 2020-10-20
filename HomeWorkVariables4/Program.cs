using System;

//Условие: Пользователь вводит 4 числа (X1, Y1, X2, Y2), описывающие координаты 2-х точек на координатно плоскости. Выведите уравнение прямой в формате Y = A * X + B, проходящие через эти точки.

namespace HomeWorkVariables4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение Координаты X1");
            int X1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение Координаты Y1");
            int Y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение Координаты X2");
            int X2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение Координаты Y2");
            int Y2 = Convert.ToInt32(Console.ReadLine());

            int A = (Y1 - Y2) / (X1 - X2);
            int B = Y2 - A * X2;

            Console.WriteLine($" Уравнение прямой Y = {A}X + {B}");
        }
    }
}
