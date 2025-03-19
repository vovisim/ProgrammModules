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

    }
}
