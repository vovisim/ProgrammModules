using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammModules
{
    internal class p7
    {
        public void t1(int number)
        {
            int firstDigit = number / 10;
            int secondDigit = number % 10;
            Console.WriteLine(firstDigit == 4 || secondDigit == 4 || firstDigit == 7 || secondDigit == 7);
            Console.WriteLine(firstDigit == 3 || secondDigit == 3 || firstDigit == 6 || secondDigit == 6 || firstDigit == 9 || secondDigit == 9);
        }

        public void t2(int n)
        {
            int[] digits = new int[4];
            digits[0] = n / 1000;
            digits[1] = (n / 100) % 10;
            digits[2] = (n / 10) % 10;
            digits[3] = n % 10;
            int count = 0;
            for (int i = 0; i < 4; i++)
            {
                int currentCount = 0;
                for (int j = 0; j < 4; j++)
                {
                    if (digits[i] == digits[j])
                    {
                        currentCount++;
                    }
                }
                if (currentCount == 3)
                {
                    count++;
                }
            }
            Console.WriteLine(count > 0);
        }

        public void t3(double a, double b, double c, double d)
        {
            int count = 0;
            if (a < 0) count++;
            if (b < 0) count++;
            if (c < 0) count++;
            if (d < 0) count++;
            Console.WriteLine(count);
        }

        public void t4(double a, double b, double c)
        {
            double discriminant = b * b - 4 * a * c;
            if (discriminant < 0)
            {
                Console.WriteLine("Вещественных корней нет");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"{x1} {x2}");
            }
        }

        public void t5(double a1, double b1, double c1, double a2, double b2, double c2)
        {
            double middle1 = a1 + b1 + c1 - Math.Max(a1, Math.Max(b1, c1)) - Math.Min(a1, Math.Min(b1, c1));
            double middle2 = a2 + b2 + c2 - Math.Max(a2, Math.Max(b2, c2)) - Math.Min(a2, Math.Min(b2, c2));
            double average = (middle1 + middle2) / 2;
            Console.WriteLine(average);
        }

        public void t6(int day)
        {
            switch (day)
            {
                case 1: Console.WriteLine("Понедельник"); break;
                case 2: Console.WriteLine("Вторник"); break;
                case 3: Console.WriteLine("Среда"); break;
                case 4: Console.WriteLine("Четверг"); break;
                case 5: Console.WriteLine("Пятница"); break;
                case 6: Console.WriteLine("Суббота"); break;
                case 7: Console.WriteLine("Воскресенье"); break;
                default: Console.WriteLine("Неверный номер дня"); break;
            }
        }

        public void t7(int month)
        {
            switch (month)
            {
                case 12: case 1: case 2: Console.WriteLine("Зима"); break;
                case 3: case 4: case 5: Console.WriteLine("Весна"); break;
                case 6: case 7: case 8: Console.WriteLine("Лето"); break;
                case 9: case 10: case 11: Console.WriteLine("Осень"); break;
                default: Console.WriteLine("Неверный номер месяца"); break;
            }
        }

        public void t8(int birthYear, int birthMonth, int birthDay, int currentYear, int currentMonth, int currentDay)
        {
            int age = currentYear - birthYear;
            if (currentMonth < birthMonth || (currentMonth == birthMonth && currentDay < birthDay))
            {
                age--;
            }
            Console.WriteLine(age);
        }

        public void t9()
        {
            for (int i = 20; i <= 35; i++)
            {
                Console.WriteLine(i);
            }

            Console.Write("Введите b (b > 10): ");
            int b = int.Parse(Console.ReadLine());
            for (int i = 10; i <= b; i++)
            {
                Console.WriteLine(i * i);
            }

            Console.Write("Введите a (a < 50): ");
            int a = int.Parse(Console.ReadLine());
            for (int i = a; i <= 50; i++)
            {
                Console.WriteLine(i * i * i);
            }

            Console.Write("Введите a и b (b < a): ");
            int a2 = int.Parse(Console.ReadLine());
            int b2 = int.Parse(Console.ReadLine());
            for (int i = a2; i <= b2; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void t10()
        {
            const double R = 6370;
            for (int h = 1; h <= 10; h++)
            {
                double distance = Math.Sqrt((R + h) * (R + h) - R * R);
                Console.WriteLine(distance);
            }
        }
    }
}
