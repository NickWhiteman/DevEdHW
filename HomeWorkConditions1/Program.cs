using System;

//Условие: Пользователь вводит 2 числа (X и Y). Определите какой четверти принадлежит точка с координатами X, Y

namespace HomeWorkConditions1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение координаты X");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение координаты Y");
            int Y = Convert.ToInt32(Console.ReadLine());

            if (X > 0 && Y > 0)
            {
                Console.WriteLine($"Точка с координатами {X}, {Y} находится во 2 четверти");
            } else if (X < 0 && Y < 0)
            {
                Console.WriteLine($"Точка с координатами {X}, {Y} находится в 3 четверти");
            } else if (X < 0 && Y > 0)
            {
                Console.WriteLine($"Точка с координатами {X}, {Y} находится в 1 четверти");
            } else if (X > 0 && Y < 0)
            {
                Console.WriteLine($"Точка с координатами {X}, {Y} находится в 4 четверти");
            } else if (X == 0 && Y == 0)
            {
                Console.WriteLine($"Точка с координатами {X}, {Y} находится в позиции ноль");
            }
        }
    }
}
