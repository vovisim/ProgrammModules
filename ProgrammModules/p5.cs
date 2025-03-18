using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammModules
{
    internal class p5
    {
        public void t1(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double minX = Math.Min(x1, x3);
            double minY = Math.Min(y1, y3);
            double maxX = Math.Max(x2, x4);
            double maxY = Math.Max(y2, y4);
            Console.WriteLine($"{minX} {minY} {maxX} {maxY}");
        }

        public void t2(double circleArea, double squareArea)
        {
            double circleRadius = Math.Sqrt(circleArea / Math.PI);
            double squareSide = Math.Sqrt(squareArea);
            Console.WriteLine(circleRadius * 2 <= squareSide);
            Console.WriteLine(squareSide * Math.Sqrt(2) <= circleRadius * 2);
        }

        public void t3(double number)
        {
            Console.WriteLine(number > -5 && number < 3);
        }

        public void t4(int number)
        {
            int firstDigit = number / 100;
            int secondDigit = (number / 10) % 10;
            int lastDigit = number % 10;
            Console.WriteLine(firstDigit > lastDigit);
            Console.WriteLine(firstDigit > secondDigit);
            Console.WriteLine(secondDigit > lastDigit);
        }

        public void t5(double a, double b, double c, double x, double y)
        {
            bool canFit = (a <= x && b <= y) || (a <= y && b <= x) ||
                          (a <= x && c <= y) || (a <= y && c <= x) ||
                          (b <= x && c <= y) || (b <= y && c <= x);
            Console.WriteLine(canFit);
        }
    }
}
