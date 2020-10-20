using System;

//Условие: Пользователь вводит 2-х значное число. Выведите в консоль прописную запись этого числа.
//Заранее извиняюсь за коряво выполненное решение.. Решил что лучше сделать примитивно и те решения которые придумал касаются других тем, решил не трогать их.
//Я не понял как воспользоваться switch case для этой задачи. 

namespace HomeWorkConditions4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 2-х значиное число");
            int A = Convert.ToInt32(Console.ReadLine());

            if (A < 20 && A > 9)
            {
                if (A == 10)
                {
                    Console.WriteLine("Десять");
                }
                else if (A == 11)
                {
                    Console.WriteLine("Одиннадцать");
                }
                else if (A == 12)
                {
                    Console.WriteLine("Двенадцать");
                }
                else if (A == 13)
                {
                    Console.WriteLine("Тринадцать");
                }
                else if (A == 14)
                {
                    Console.WriteLine("Четырнадцать");
                }
                else if (A == 15)
                {
                    Console.WriteLine("Пятнадцать");
                }
                else if (A == 16)
                {
                    Console.WriteLine("Шестнадцать");
                }
                else if (A == 17)
                {
                    Console.WriteLine("Семнадцать");
                }
                else if (A == 18)
                {
                    Console.WriteLine("Восемнадцать");
                }
                else if (A == 19)
                {
                    Console.WriteLine("Девятнадцать");
                }
            }
            else if (A > 19 && A < 30)
            {
                if (A == 20)
                {
                    Console.WriteLine("Двадцать");
                }
                else if (A == 21)
                {
                    Console.WriteLine("Двадцать один");
                }
                else if (A == 22)
                {
                    Console.WriteLine("Двадцать два");
                }
                else if (A == 23)
                {
                    Console.WriteLine("Двадцать три");
                }
                else if (A == 24)
                {
                    Console.WriteLine("Двадцать четыре");
                }
                else if (A == 25)
                {
                    Console.WriteLine("Двадцать пять");
                }
                else if (A == 26)
                {
                    Console.WriteLine("Двадцать шесть");
                }
                else if (A == 27)
                {
                    Console.WriteLine("Двадцать семь");
                }
                else if (A == 28)
                {
                    Console.WriteLine("Двадцать восемь");
                }
                else if (A == 29)
                {
                    Console.WriteLine("Двадцать девять");
                }
            }
            else if (A > 29 && A < 40)
            {
                if (A == 30)
                {
                    Console.WriteLine("Тридцать");
                }
                else if (A == 31)
                {
                    Console.WriteLine("Тридцать один");
                }
                else if (A == 32)
                {
                    Console.WriteLine("Тридцать два");
                }
                else if (A == 33)
                {
                    Console.WriteLine("Тридцать три");
                }
                else if (A == 34)
                {
                    Console.WriteLine("Тридцать четыре");
                }
                else if (A == 35)
                {
                    Console.WriteLine("Тридцать пять");
                }
                else if (A == 36)
                {
                    Console.WriteLine("Тридцать шесть");
                }
                else if (A == 37)
                {
                    Console.WriteLine("Тридцать семь");
                }
                else if (A == 38)
                {
                    Console.WriteLine("Тридцать восемь");
                }
                else if (A == 39)
                {
                    Console.WriteLine("Тридцать девять");
                }
            }
            else if (A > 39 && A < 50)
            {
                if (A == 40)
                {
                    Console.WriteLine("Сорок");
                }
                else if (A == 41)
                {
                    Console.WriteLine("Сорок один");
                }
                else if (A == 42)
                {
                    Console.WriteLine("Сорок два");
                }
                else if (A == 43)
                {
                    Console.WriteLine("Сорок три");
                }
                else if (A == 44)
                {
                    Console.WriteLine("Сорок четыре");
                }
                else if (A == 45)
                {
                    Console.WriteLine("Сорок пять");
                }
                else if (A == 46)
                {
                    Console.WriteLine("Сорок шесть");
                }
                else if (A == 47)
                {
                    Console.WriteLine("Сорок семь");
                }
                else if (A == 4)
                {
                    Console.WriteLine("Сорок восемь");
                }
                else if (A == 49)
                {
                    Console.WriteLine("Сорок девять");
                }
            }
            else if (A > 49 && A < 60)
            {
                if (A == 50)
                {
                    Console.WriteLine("Пятьдесят");
                }
                else if (A == 51)
                {
                    Console.WriteLine("Пятьдесят один");
                }
                else if (A == 52)
                {
                    Console.WriteLine("Пятьдесят два");
                }
                else if (A == 53)
                {
                    Console.WriteLine("Пятьдесят три");
                }
                else if (A == 54)
                {
                    Console.WriteLine("Пятьдесят четыре");
                }
                else if (A == 55)
                {
                    Console.WriteLine("Пятьдесят пять");
                }
                else if (A == 56)
                {
                    Console.WriteLine("Пятьдесят шесть");
                }
                else if (A == 57)
                {
                    Console.WriteLine("Пятьдесят семь");
                }
                    else if (A == 58)
                {
                    Console.WriteLine("Пятьдесят восемь");
                }
                else if (A == 59)
                {
                    Console.WriteLine("Пятьдесят девять");
                }
            }
            else if (A > 59 && A < 70)
            {
                if (A == 60)
                {
                    Console.WriteLine("Шестьдесят");
                }
                else if (A == 61)
                {
                    Console.WriteLine("Шестьдесят один");
                }
                else if (A == 62)
                {
                    Console.WriteLine("Шестьдесят два");
                }
                else if (A == 63)
                {
                    Console.WriteLine("Шестьдесят три");
                }
                else if (A == 64)
                {
                    Console.WriteLine("Шестьдесят четыре");
                }
                else if (A == 65)
                {
                    Console.WriteLine("Шестьдесят пять");
                }
                else if (A == 66)
                {
                    Console.WriteLine("Шестьдесят шесть");
                }
                else if (A == 67)
                {
                    Console.WriteLine("Шестьдесят семь");
                }
                else if (A == 68)
                {
                    Console.WriteLine("Шестьдесят восемь");
                }
                else if (A == 69)
                {
                    Console.WriteLine("Шестьдесят девять");
                }
            }
            else if (A > 69 && A < 80)
            {
                if (A == 70)
                {
                    Console.WriteLine("Семьдесят");
                }
                else if (A == 71)
                {
                    Console.WriteLine("Семьдесят один");
                }
                else if (A == 72)
                {
                    Console.WriteLine("Семьдесят два");
                }
                else if (A == 73)
                {
                    Console.WriteLine("Семьдесят три");
                }
                else if (A == 74)
                {
                    Console.WriteLine("Семьдесят четыре");
                }
                else if (A == 75)
                {
                    Console.WriteLine("Семьдесят пять");
                }
                else if (A == 76)
                {
                    Console.WriteLine("Семьдесят шесть");
                }
                else if (A == 77)
                {
                    Console.WriteLine("Семьдесят семь");
                }
                else if (A == 78)
                {
                    Console.WriteLine("Семьдесят восемь");
                }
                else if (A == 79)
                {
                    Console.WriteLine("Семьдесят девять");
                }
            }
            else if (A > 79 && A < 90)
            {
                if (A == 80)
                {
                    Console.WriteLine("Восемьдесят");
                }
                else if (A == 81)
                {
                    Console.WriteLine("Восемьдесят один");
                }
                else if (A == 82)
                {
                    Console.WriteLine("Восемьдесят два");
                }
                else if (A == 83)
                {
                    Console.WriteLine("Восемьдесят три");
                }
                else if (A == 84)
                {
                    Console.WriteLine("Восемьдесят четыре");
                }
                else if (A == 85)
                {
                    Console.WriteLine("Восемьдесят пять");
                }
                else if (A == 86)
                {
                    Console.WriteLine("Восемьдесят шесть");
                }
                else if (A == 87)
                {
                    Console.WriteLine("Восемьдесят семь");
                }
                else if (A == 88)
                {
                    Console.WriteLine("Восемьдесят восемь");
                }
                else if (A == 89)
                {
                    Console.WriteLine("Восемьдесят девять");
                }
            }
            else if (A > 89 && A < 100)
            {
                if (A == 90)
                {
                    Console.WriteLine("Шестьдесят");
                }
                else if (A == 91)
                {
                    Console.WriteLine("Девяносто один");
                }
                else if (A == 92)
                {
                    Console.WriteLine("Девяносто два");
                }
                else if (A == 93)
                {
                    Console.WriteLine("Девяносто три");
                }
                else if (A == 94)
                {
                    Console.WriteLine("Девяносто четыре");
                }
                else if (A == 95)
                {
                    Console.WriteLine("Девяносто пять");
                }
                else if (A == 96)
                {
                    Console.WriteLine("Девяносто шесть");
                }
                else if (A == 97)
                {
                    Console.WriteLine("Девяносто семь");
                }
                else if (A == 98)
                {
                    Console.WriteLine("Девяносто восемь");
                }
                else if (A == 99)
                {
                    Console.WriteLine("Девяносто девять");
                }
            }
            else if (A > 99 || A < 10)
            {
                Console.WriteLine("Ошибка : число не 2-х значное");
            }
        }
    }
}
