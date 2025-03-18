using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammModules
{
    internal class p1
    {
        public void t1()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number);

        }

        static void t2()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number);

        }

        static void t3(int side)
        {
            int perimeter = 4 * side;
            Console.WriteLine(perimeter);
        }

        static void t4(int radius)
        {
            int diameter = 2 * radius;
            Console.WriteLine(diameter);
        }


        static void t5(double volume, double mass)
        {
            double density = mass / volume;
            Console.WriteLine(density);
        }

        static void t6(double base1, double base2, double height)
        {
            double side = Math.Sqrt(Math.Pow((base2 - base1) / 2, 2) + Math.Pow(height, 2));
            double perimeter = base1 + base2 + 2 * side;
            Console.WriteLine(perimeter);

        }

        static void t7(int massKg)
        {
            int tons = massKg / 1000;
            Console.WriteLine(tons);

        }

        static void t8(int distanceMeters)
        {
            int kilometers = distanceMeters / 1000;
            Console.WriteLine(kilometers);
        }

        static void t9(int number)
        {
            int tens = number / 10;
            int units = number % 10;
            int sum = tens + units;
            int product = tens * units;


            Console.WriteLine(tens);
            Console.WriteLine(units);
            Console.WriteLine(sum);
        }

        static void t10(int number)
        {
            int reversedNumber = (number % 10) * 100 + ((number / 10) % 10) * 10 + (number / 100);
            Console.WriteLine(reversedNumber);
        }
    }
}
