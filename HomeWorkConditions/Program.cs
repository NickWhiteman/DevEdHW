using System;

//Условие: Пользователь вводит 2 числа (A и B). Если A>B, посчитать A+B, если A=B, посчитать A*B, если A<B, посчитать A-B.

namespace HomeWorkConditions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение переменной A");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение переменной B");
            int B = Convert.ToInt32(Console.ReadLine());

            if (A > B)
            {
                Console.WriteLine($"A > B -> {A + B}");
            } else if (A == B)
            { 
                Console.WriteLine($"A = B -> {A * B}");
            } else if (A < B)
            {
                Console.WriteLine($"A < B -> {A - B}");
            }

        }
    }
}
