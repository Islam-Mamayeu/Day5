using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;

namespace TestSortJaggedArray
{
    class ComparatorMaxElementAsc : IJaggedArraySortComparer
    {
        public int Compare(int[] a, int[] b)
        {
            if (Max(a) > Max(b)) return 1;
            if (Max(a) == Max(b)) return 0;
            return -1;
        }

        public static int Max(int[] Array)
        {
            int max = Array[0];
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] > max)
                    max = Array[i];
            }
            return max;
        }

    }
}
