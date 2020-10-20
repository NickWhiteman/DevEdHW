using System;

// Условие: Пользователь вводит 2 числа (A и B). Поменяйте содержимое переменных A и B местами.

namespace HomeWorkVariables1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число в переменную A");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число в переменную B");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Было : A = {A} , B = {B}");

            (A, B) = (B, A);

            Console.WriteLine($"Стало: A = {A} , B = {B}");
        }
    }
}

//Топорно решил и на всякий случай реабилитирующее решение в котором я не уверен но : 

            /*
             * Console.WriteLine("Введите число в переменную A");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число в переменную B");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Было : A = {A} , B = {B}");

            int C = B;
            B = A;
            A = C;

            Console.WriteLine($"Стало: A = {A} , B = {B}");
            */