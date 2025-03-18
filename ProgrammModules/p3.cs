using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammModules
{
    internal class p3
    {
        public void t1(double x, double y)
        {
            Console.WriteLine(x < 2 && y < 3);
            Console.WriteLine(!(x < 2));
            Console.WriteLine(x < 1 || y < 2);
            Console.WriteLine(!(x < 0 && x < 5));
            Console.WriteLine(x < 0 && y > 5);
            Console.WriteLine(x > 10 && x < 20);
            Console.WriteLine(x > 3 || x < 1);
            Console.WriteLine(y > 0 && y < 4 && x < 5);
            Console.WriteLine(x > 3 && x < 10);
        }

        public void t2(int X, int Y, int Z)
        {
            Console.WriteLine(X % 2 != 0 && Y % 2 != 0);
            Console.WriteLine((X < 20 && Y >= 20) || (X >= 20 && Y < 20));
            Console.WriteLine(X == 0 || Y == 0);
            Console.WriteLine(X < 0 && Y < 0 && Z < 0);
            Console.WriteLine((X % 5 == 0 && Y % 5 != 0 && Z % 5 != 0) || (X % 5 != 0 && Y % 5 == 0 && Z % 5 != 0) || (X % 5 != 0 && Y % 5 != 0 && Z % 5 == 0));
            Console.WriteLine(X > 100 || Y > 100 || Z > 100);
        }

        public void t3(double x)
        {
            double y = x > 0 ? Math.Sin(x) : Math.Cos(x);
            Console.WriteLine(y);
        }

        public void t4(int a, int b)
        {
            Console.WriteLine(b % a == 0);
        }

        public void t5(int number)
        {
            Console.WriteLine(number % 2 == 0);
            Console.WriteLine(number % 10 == 7);
        }

        public void t6(double km, double feet)
        {
            double meters = feet * 0.305;
            Console.WriteLine(km * 1000 < meters);
        }

        public void t7(double a, double b, double c)
        {
            double discriminant = b * b - 4 * a * c;
            Console.WriteLine(discriminant >= 0);
        }

        public void t8(double circleArea, double squareArea)
        {
            double circleRadius = Math.Sqrt(circleArea / Math.PI);
            double squareSide = Math.Sqrt(squareArea);
            Console.WriteLine(circleRadius * 2 <= squareSide);
            Console.WriteLine(squareSide * Math.Sqrt(2) <= circleRadius * 2);
        }

        public void t9(double number)
        {
            Console.WriteLine(number > -5 && number < 3);
        }

        public void t10(double a, double b, double c)
        {
            Console.WriteLine(a == b && b == c);
        }
    }
}
