using System;

//Условие: Пользователь вводит 3 числа. Выведите в консоль решение (Значение X) квадратного уравнения стандартного вида, где A * Math.Pow(X, 2) + BX + C = 0.

namespace HomeWorkConditions3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число A");
            double A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B");
            double B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число C");
            double C = Convert.ToInt32(Console.ReadLine());

            double Result;

            if (A != 0)
            {
                if (B == 0)
                {
                    Result = Math.Sqrt(C * -1 / A);
                    Console.WriteLine($"x1 =  {Result} \n x2 = {(Result * -1)}");
                }
                else if (C == 0)
                {
                    Result = B * -1 / A;
                    Console.WriteLine($"x1 = {0}  \n x2 = {Result}");
                }
                else
                {
                    double sqrtD = Math.Sqrt(B * B - 4 * A * C);
                    Console.WriteLine($"x1 = {((B * -1 + sqrtD) / 2 * A)} x2 = {((B * -1 - sqrtD) / 2 * A)}");
                }
            }
            else
                Console.WriteLine("Ошибка! (A = 0)");
        }
    }
}
