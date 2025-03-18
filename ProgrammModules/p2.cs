using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammModules
{
    internal class p2
    {
        public void t1()
        {

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"{i}\t{i * i}");
            }
            Console.WriteLine();
        }


        public void t2(int n)
        {

            double sum = 0;
            double sinSum = 0;

            for (int i = 1; i <= n; i++)
            {
                sinSum += Math.Sin(i * Math.PI / 180);
                sum += 1 / sinSum;
            }

            Console.WriteLine(sum);
        }


        public void t3(double a, double b, double h)
        {

            for (double x = a; x <= b; x += h)
            {
                double fx = Math.Sin(x) + Math.Cos(x);
                Console.WriteLine($"{x}\t{fx}");
            }

        }
    }
}
