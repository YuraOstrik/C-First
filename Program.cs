using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incaption13._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 1 - 100 : ");
            string input = Console.ReadLine();

            bool IsNum = true;
            foreach (char p in input)
            {
                if (!char.IsDigit(p))
                {
                    IsNum = false;
                    break;
                }
            }

            if (IsNum)
            {
                int num = int.Parse(input);

                if (num >= 1 && num <= 100)
                {
                    if (num % 3 == 0 && num % 5 == 0)
                    {
                        Console.WriteLine("Fizz Buzz");
                    }
                    else if (num % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if (num % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine(num);
                    }
                }
                else
                {
                    Console.WriteLine("Число не входит в диапазон");
                }
            }
            else
            {
                Console.WriteLine("Это не число");
            }

            Console.WriteLine(" Ведите число ");
            string Value = Console.ReadLine();
            Console.WriteLine(" Ведите процент ");
            string Percent = Console.ReadLine();

            double value = double.Parse(Value);
            double percent = double.Parse(Percent);

            double result = value * percent / 100;
            Console.WriteLine($"И того {result}");

            Console.WriteLine("Введите 4 числа");
            string a = Console.ReadLine();
            string b = Console.ReadLine();  
            string c = Console.ReadLine();  
            string d = Console.ReadLine();

            string res = a + b + c + d;
            Console.WriteLine($"Result = {res}");

            Console.WriteLine("Введите шестизначное число ");
            string six = Console.ReadLine();

            if (six.Length == 6)
            {
                Console.WriteLine("Введите два номера разряда для обмена ");

                int pos1 = int.Parse(Console.ReadLine());
                int pos2 = int.Parse(Console.ReadLine());

                int index1 = pos1 - 1;
                int index2 = pos2 - 1;

                char[] digits = six.ToCharArray();


                char temp = digits[index1];
                digits[index1] = digits[index2];
                digits[index2] = temp;
                string re = new string(digits);
                Console.WriteLine($" -- Res --- {re}");
            }

            Console.WriteLine("Введите показания температуры:");
            string inputTemperature = Console.ReadLine();

            if (double.TryParse(inputTemperature, out double temperature))
            {
                Console.WriteLine("Выберите опцию для перевода температуры:");
                Console.WriteLine("1 - Из Фаренгейта в Цельсий");
                Console.WriteLine("2 - Из Цельсия в Фаренгейт");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    
                    double celsius = (temperature - 32) * 5 / 9;
                    Console.WriteLine($"{temperature} °F = {celsius:F2} °C");
                }
                else if (choice == "2")
                {
                   
                    double fahrenheit = (temperature * 9 / 5) + 32;
                    Console.WriteLine($"{temperature} °C = {fahrenheit:F2} °F");
                }
                else
                {
                    Console.WriteLine("Ошибка: Некорректный выбор опции.");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: Введено некорректное значение температуры.");
            }

            Console.WriteLine("Введите первое число:");
            string int1 = Console.ReadLine();

            Console.WriteLine("Введите второе число:");
            string int2 = Console.ReadLine();

            
            if (int.TryParse(int1, out int num1) && int.TryParse(int2, out int num2))
            {
                
                int start = Math.Min(num1, num2);
                int end = Math.Max(num1, num2);

                Console.WriteLine($"Четные числа в диапазоне от {start} до {end}:");

                
                for (int i = start; i <= end; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(i + " ");
                    }
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Ошибка: Введены некорректные числа.");
            }
        }
    }
}
