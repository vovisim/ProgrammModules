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

        public void t4(int height, int width, char symbol)
        {

            if (height % 2 == 0 || width % 2 == 0)
            {
                Console.WriteLine("Высота и ширина должны быть нечётными числами.");
                return;
            }

            int midWidth = width / 2;
            int midHeight = height / 2;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (Math.Abs(j - midWidth) <= midHeight - Math.Abs(i - midHeight))
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }


        public void t5(int n)
        {

            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(1, 100);
            }


            Console.WriteLine(string.Join(", ", array));
            Console.WriteLine();
            Console.WriteLine("Нечётные числа в массиве:");
            foreach (int num in array)
            {
                if (num % 2 != 0)
                {
                    Console.Write(num + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
