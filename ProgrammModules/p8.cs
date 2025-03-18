using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammModules
{
    internal class p8
    {
        public void t1(double x, double y)
        {
            if (x > 0 && y > 0) Console.WriteLine(1);
            else if (x < 0 && y > 0) Console.WriteLine(2);
            else if (x < 0 && y < 0) Console.WriteLine(3);
            else if (x > 0 && y < 0) Console.WriteLine(4);
        }

        public void t2(int number)
        {
            int firstHalf = number / 1000;
            int secondHalf = number % 1000;
            int sumFirst = (firstHalf / 100) + ((firstHalf / 10) % 10) + (firstHalf % 10);
            int sumSecond = (secondHalf / 100) + ((secondHalf / 10) % 10) + (secondHalf % 10);
            Console.WriteLine(sumFirst == sumSecond);
        }

        public void t3(int k, int d)
        {
            int dayOfWeek = (k + d - 1) % 7;
            switch (dayOfWeek)
            {
                case 0: Console.WriteLine("Воскресенье"); break;
                case 1: Console.WriteLine("Понедельник"); break;
                case 2: Console.WriteLine("Вторник"); break;
                case 3: Console.WriteLine("Среда"); break;
                case 4: Console.WriteLine("Четверг"); break;
                case 5: Console.WriteLine("Пятница"); break;
                case 6: Console.WriteLine("Суббота"); break;
            }
        }

        public void t4(int m, int n)
        {
            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            int prevDay = n - 1;
            int prevMonth = m;
            if (prevDay == 0)
            {
                prevMonth--;
                if (prevMonth == 0) prevMonth = 12;
                prevDay = daysInMonth[prevMonth - 1];
            }
            Console.WriteLine($"{prevDay}.{prevMonth}");

            int nextDay = n + 1;
            int nextMonth = m;
            if (nextDay > daysInMonth[nextMonth - 1])
            {
                nextDay = 1;
                nextMonth++;
                if (nextMonth == 13) nextMonth = 1;
            }
            Console.WriteLine($"{nextDay}.{nextMonth}");
        }

        public void t5(double a, double b, double c)
        {
            Console.WriteLine(a + b > c && a + c > b && b + c > a);
        }

        public void t6(double a, double b, double c)
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                double max = Math.Max(a, Math.Max(b, c));
                if (max == a) Console.WriteLine(b * b + c * c == a * a);
                else if (max == b) Console.WriteLine(a * a + c * c == b * b);
                else Console.WriteLine(a * a + b * b == c * c);
            }
            else
            {
                Console.WriteLine(false);
            }
        }

        public void t7(double pricePerKg)
        {
            for (int weight = 50; weight <= 1000; weight += 50)
            {
                Console.WriteLine($"{weight} г = {pricePerKg * weight / 1000} руб");
            }
        }

        public void t8()
        {
            for (double i = 2.1; i <= 2.8; i += 0.1)
            {
                Console.WriteLine(i);
            }
        }

        public void t9()
        {
            int sum = 0;
            for (int i = 100; i <= 500; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);

            Console.Write("Введите a (a < 500): ");
            int a = int.Parse(Console.ReadLine());
            sum = 0;
            for (int i = a; i <= 500; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);

            Console.Write("Введите b (b > -10): ");
            int b = int.Parse(Console.ReadLine());
            sum = 0;
            for (int i = -10; i <= b; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);

            Console.Write("Введите a и b (b > a): ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            sum = 0;
            for (int i = a; i <= b; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }

        public void t10()
        {
            long product = 1;
            for (int i = 8; i <= 15; i++)
            {
                product *= i;
            }
            Console.WriteLine(product);

            Console.Write("Введите a (1 <= a <= 20): ");
            int a = int.Parse(Console.ReadLine());
            product = 1;
            for (int i = a; i <= 20; i++)
            {
                product *= i;
            }
            Console.WriteLine(product);

            Console.Write("Введите b (1 <= b <= 20): ");
            int b = int.Parse(Console.ReadLine());
            product = 1;
            for (int i = 1; i <= b; i++)
            {
                product *= i;
            }
            Console.WriteLine(product);

            Console.Write("Введите a и b (b > a): ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            product = 1;
            for (int i = a; i <= b; i++)
            {
                product *= i;
            }
            Console.WriteLine(product);
        }
    }
}
