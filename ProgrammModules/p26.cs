using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammModules
{
    internal class p26
    {

        public int t1(int[,] a)
        {

            int lenSum = a.Length * 2;
            HashSet<int> uniqSet = new HashSet<int>();

            foreach (int i in a)
            {

                uniqSet.Add(i);

            }

            return uniqSet.Count;


        }

        int[] t2(int[,] a) {

            int max = a[0, 0];
            int min = a[0, 0];
            

            foreach (int i in a)
            {
                if (i > max)
                {
                    max = i;
                }
                if (i < min) {
                
                    min = i;
                
                }
            }

            int[] otvet = new int[2] { max, min };

            return otvet;
        
        }

        int t3(string str)
        {
            return str.Split(' ').Length;
        }

        string rev(string s)
        {
            string ns = "";
            for (int i = s.Length - 1; i < 0; i++)
            {

                ns += s[i];

            }

            return ns;
        }

        string t4(string s) {

            string ns = "";

            foreach (var item in s.Split(' '))
            {
                ns += rev(item) + " ";
            }

            return ns;

        }

        int t5(string s) {

            string str = "";
            string[] vowels = new string[6] { "a", "e", "i", "o", "u", "y" };
            int counter = 0;

            foreach (var item in str.Split("")) {

                if (vowels.Contains(item))
                {
                    counter++;
                }
            
            }

            return counter;
        }

        int t6(string str, string substr)
        {

            int index = 0;
            int counter = 0;

            while (index != str.Length) {
            
                if(str.IndexOf(substr, index) != -1)
                {
                    index = str.IndexOf(substr, index);
                    counter++;
                } 

                
            
            }

            return counter;

        }



    }
}
