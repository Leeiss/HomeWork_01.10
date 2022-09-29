using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tumakov
{
    enum DayOfWeek
    {
        Понедельник = 0,
        Вторник = 1,
        Среда = 2,
        Четверг = 3,
        Пятницa = 4,
        Суббота = 5,
        Воскресенье = 6
    }
    enum Carts
    {
        Шестерка = 6,
        Семерка = 7,
        Восьмерка = 8,
        Девятка = 9,
        Десятка = 10,
        Валет = 11,
        Дама = 12,
        Король = 13,
        Туз = 14
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 задание с форточкой");
            Console.Write("Введите a (длину форточки): ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите b (ширину форточки): ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите d (диаметр головы Вани): ");
            double d = double.Parse(Console.ReadLine());
            if (a - d >= 2 && b - d >= 2)
            {
                Console.WriteLine("Ваня сможет высунуть голову из форточки");
            }
            else
            {
                Console.WriteLine("Ваня не сможет высунуть голову из форточки");
            }
            Console.WriteLine();



            Console.WriteLine("2 задание, таблица умножения");
            Console.Write("Введите число n в диапозоне 1-9: ");
            short n = short.Parse(Console.ReadLine());
            if (n < 1 || n > 9)
                Console.WriteLine("Пожалуйста, введите число в диапозоне 1-9");
            else
            {
                for (int k = 0; k < 10; k++)
                {
                    Console.WriteLine($"{k}*{n}={k * n}");
                }
            }
            Console.WriteLine();


            Console.WriteLine("Задание 3, проверка на деление");
            Console.Write("Введите число: ");
            int chislo = int.Parse(Console.ReadLine());
            if (chislo % 3 == 0 && chislo % 5 == 0)
            {
                Console.WriteLine("БэнгБум");
            }
            else if (chislo % 3 == 0)
            {
                Console.WriteLine("Бэнг");
            }
            else if (chislo % 5 == 0)
            {
                Console.WriteLine("Бум");
            }
            else
            {
                Console.WriteLine("Мимо");
            }
            Console.WriteLine();


            Console.WriteLine("4 задание, проверить, введена ли заглавными буквами строка");
            Console.Write("Введите строку: ");
            string stroka = Console.ReadLine();
            int c = 0;
            foreach (char simvol in stroka)
            {
                if (char.IsUpper(simvol))
                {
                    c++;
                }
            }
            if (c == stroka.Length)
                Console.WriteLine("Cтрока с консоли состоит из заглавных букв");
            else
                Console.WriteLine("В строке с консоли присутствуют строчные буквы");
            Console.WriteLine();


            Console.WriteLine("5 задание, вывести строку по шаблону");
            Console.Write("Введите целое положительное число: ");
            int ch = int.Parse(Console.ReadLine());
            int ii = 1;
            while (ii <= ch)
            {
                Console.Write($"{ii}овца...");
                ii++;
            }
            Console.WriteLine();



            Console.WriteLine("6 задание, среднее арифметическое прогрессии");
            Console.Write("Введите через пробел последовательность неотрицательных целых чисел, оканчивающуюся отрицательным числом: ");
            string str = Console.ReadLine();
            string[] str_1 = str.Split(' ');
            int[] posl = new int[str_1.Length];
            for (int i_ = 0; i_ < posl.Length; i_++)
                posl[i_] = int.Parse(str_1[i_]);
            double sum = 0;
            try
            {
                for (int i_ = 0; i_ < (posl.Length - 1); i_++)
                    sum += posl[i_];
                double sr_arif = sum / (posl.Length - 1);
                Console.WriteLine($"Среднее арифметическое равно {sr_arif}");
            }
            catch (Exception)
            {
                Console.WriteLine("Пожалуйста, введите последовательность корректно");
            }
            Console.WriteLine();



            Console.WriteLine("7 задание, достоинство карты");
            Console.Write("Введите номер карты: ");
            try
            {
                byte cart = byte.Parse(Console.ReadLine());
                if (cart >= 6 && cart <= 14)
                {
                    Console.WriteLine($"Достоинство карты - {(Carts)cart}");
                }
                else
                    Console.WriteLine("Пожалуйста, корректно введите номер карты");
            }
            catch (Exception)
            {
                Console.WriteLine("Пожалуйста, корректно введите номер карты");
            }

            Console.WriteLine();



            Console.WriteLine("8 задание, сколько кукол в сумке");
            string[] dols = { "Teddy Bear", "Hello Kitty", "Hello Kitty", "Monster high", "Barbie doll", "Teddy Bear", "Barbie doll" };
            int count = 0;
            foreach (string j in dols)
            {
                if (j == "Hello Kitty" || j == "Barbie doll")
                    count++;
            }
            Console.WriteLine($"Количество кукол Hello Kitty и Barbie doll = {count}");



            Console.WriteLine("9 задание, день недели");
            Console.Write("Введите номер дня в неделе: ");
            byte den = byte.Parse(Console.ReadLine());
            if (den > 7 || den < 1)
            {
                Console.WriteLine("Пожалуйста, корректно введите номер деня недели");
            }
            else
            {
                Console.WriteLine($"День недели - {(DayOfWeek)(den - 1)}");
            }
            Console.WriteLine();



            Console.WriteLine("10 задание, сортировка массива");
            Console.WriteLine("1) Сортировка массива методом пузырька");
            int[] m = { 1, 345, -98, 34, 567, 21, -1, 0, 45, 2999, -1289 };
            Console.WriteLine("Неотсортированный массив: ");
            for (int I = 0; I < m.Length; I++)
            {
                Console.Write(m[I] + " ");
            }
            int temp;
            for (int I = 0; I < m.Length - 1; I++)
            {
                for (int j = I + 1; j < m.Length; j++)
                {
                    if (m[I] > m[j])
                    {
                        temp = m[I];
                        m[I] = m[j];
                        m[j] = temp;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Отсортированный массив: ");
            for (int I = 0; I < m.Length; I++)
            {
                Console.Write(m[I] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("\n2) Сортировка массива с помощью встроенных методов ");
            Array.Sort(m);
            foreach (int I in m)
                Console.Write(I + " ");
            Console.WriteLine();


            Console.WriteLine("11 задание, определить, является ли последовательность упорядоченной");
            int num, exnum = 0;
            int i;
            Console.WriteLine("Введите последовательность из 10 чисел:");
            i = 0;
            num = int.Parse(Console.ReadLine());
            exnum = num;
            while (i < 9)
            {
                if (exnum > num)
                {
                    break;
                }
                else
                {
                    i++;
                    num = int.Parse(Console.ReadLine());
                }
            }
            if (i == 9)
                Console.WriteLine("Последовательность является упорядоченной");
            else
            {
                Console.WriteLine("Последовательность не является упорядоченной");
                Console.WriteLine($"Номер числа, нарушающего эту последовательность - {i + 1}");
            }
            Console.WriteLine();
        }

    }

}

