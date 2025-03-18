using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammModules
{
    internal class p2_1
    {

        public void t1(double x, double a)
        {
            double y = 7 * Math.Pow(x, 2) + 3 * x + 6;
            double xValue = 12 * Math.Pow(a, 2) + 7 * a + 12;


            Console.WriteLine(y);
            Console.WriteLine(xValue);
   
        }

        public void t2(double a, double b)
        {
          
            double x = -b / a;
            Console.WriteLine(x);

        }


        public void t3(double cathetus1, double cathetus2)
        {
            double hypotenuse = Math.Sqrt(Math.Pow(cathetus1, 2) + Math.Pow(cathetus2, 2));
            double perimeter = cathetus1 + cathetus2 + hypotenuse;
            Console.WriteLine(perimeter);

        }

        public void t4(double base1, double base2, double height)
        {
            double side = Math.Sqrt(Math.Pow((base2 - base1) / 2, 2) + Math.Pow(height, 2));
            double perimeter = base1 + base2 + 2 * side;


            Console.WriteLine(perimeter);
        }

        public void t5(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            double side1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double side2 = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            double side3 = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));

            double perimeter = side1 + side2 + side3;
            double area = Math.Abs((x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2);

            Console.WriteLine(perimeter);
            Console.WriteLine(area);

        }

        public void t6()
        {
            int result = 237;
            int lastDigit = result / 100;
            int remainingNumber = result % 100; 

            int originalNumber = remainingNumber * 10 + lastDigit;

            Console.WriteLine(originalNumber);

        }


        public void t7()
        {
            bool A = true, B = false, C = false;

            Console.WriteLine(A || B);
            Console.WriteLine(A && B);
            Console.WriteLine(B || C);

        }

        public void t8()
        {
            bool A = true, B = false, C = false;


            Console.WriteLine(!A && B);
            Console.WriteLine(A || !B);
            Console.WriteLine(A && B || C);

        }

        public void t9()
        {
            bool A = true, B = false, C = false;

            Console.WriteLine(A || B && !C);
            Console.WriteLine(!A && !B);
            Console.WriteLine(!(A && C) || B);
            Console.WriteLine(A && !B || C);
            Console.WriteLine(A && (!B || C));
            Console.WriteLine(A || !(B && C));

        }


        public void t10(double x, double y)
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
    }
}
