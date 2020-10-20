using System;

//Условие: Пользователь вводит 3 числа (A, B, C). Выведите их в консоль в порядке возрастания.

namespace HomeWorkConditions2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число А");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число B");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число C");
            int C = Convert.ToInt32(Console.ReadLine());

            if (A > B && A > C && B > C)
            {
                Console.WriteLine($"{C}, {B}, {A} от меньшему к большему");
            }
            else if (B > A && B > C && A > C)
            {
                Console.WriteLine($"{C}, {A}, {B} от меньшему к большему");
            }
            else if (C > A && C > B && A > B)
            {
                Console.WriteLine($"{B}, {A}, {C} от меньшему к большему");
            }
            else if (A > B && A > C && C > B)
            {
                Console.WriteLine($"{B}, {C}, {A} от меньшему к большему");
            }
            else if (B > A && B > C && C > A)
            {
                Console.WriteLine($"{A}, {C}, {B} от меньшему к большему");
            }
            else if (C > A && C > B && B > A)
            {
                Console.WriteLine($"{A}, {B}, {C} от меньшему к большему");
            }
            else if (C > A && C > B && B == A)
            {
                Console.WriteLine($"{A}, {B}, {C} от меньшему к большему");
            }
            else if (C == A && C == B && B == A)
            {
                Console.WriteLine($"{A}, {B}, {C} от меньшему к большему");
            }
            else if (C == A && C > B)
            {
                Console.WriteLine($"{B}, {A}, {C} от меньшему к большему");
            }
            else if (C > A && C == B)
            {
                Console.WriteLine($"{A}, {B}, {C} от меньшему к большему");
            }
        }
    }
}
