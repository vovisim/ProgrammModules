//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ProgrammModules
//{
//    internal class p16
//    {
//        public void t1(int[][] a)
//        {
//            int positiveNumber = 0;
//            int negativeNumber = 0;

//            for (int i = 0; i < a.Length; i++) {
//                for (int j = 0; j < a[i].Length; j++)
//                {

//                    if (a[i][j] > 0) { positiveNumber++; }
//                    else {  negativeNumber++; }

//                    if (i == 0 || j == 0 || i == a.Length-1 || j == a[i].Length-1)
//                    {
//                        Console.Write(a[i][j] + " ");
//                    }
                   
//                }
//            }
//            Console.WriteLine("Числа");
//            int[] z = new int[] { positiveNumber, negativeNumber };
//            Console.Write(positiveNumber + " ");
//            Console.Write(negativeNumber);

//        }

//        public void t2(string w1, string w2)
//        {

//            string longWord = w1.Length > w2.Length ? w1 : w2;
//            string shortWord = w1.Length < w2.Length ? w1 : w2;
//            int differense = longWord.Length - shortWord.Length;

//            Console.WriteLine(longWord);
//            Console.WriteLine(shortWord + longWord.Substring(0, differense));


//        }

//        public void t3(string s1)
//        {
//            int counter = 0;
//            for (int i = 0; i < s1.Length - 1; i++)
//            {

//                if (s1[i] == 'n' && s1[i + 1] == 'n')
//                {

//                    counter++;

//                }

//            }

//            Console.WriteLine(counter);

//        }

//        public string t4(string s1) {

//            return s1.LastIndexOf("c") > s1.LastIndexOf("t") ? "c" : "t";
        
//        }

//        public bool t5(string s1)
//        {

//            for (int i = 0; i < s1.Length - 5; i++)
//            {

//                if (s1[i] == s1[i + 1] && s1[i] == s1[i + 2] && s1[i] == s1[i + 3] && s1[i] == s1[i + 4])
//                {

//                    return true;

//                }
                

//            }
//            return false;

//        }

//    }

//}
