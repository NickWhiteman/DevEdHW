using System;

//Условие: Пользователь вводит 2 числа (A и B). Выведите в консоль результат деления A на B и отстаток от деления

namespace HomeWorkVariables2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число в переменную A");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число в переменную B");
            int B = Convert.ToInt32(Console.ReadLine());

            int C = A / B;
            int D = A % B;
            Console.WriteLine($"Результат деления A / B = {C}");
            Console.WriteLine($"Остаток от деления: {D}");

        }
    }
}
