using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;

namespace TestSortJaggedArray
{
    class ComparatorSumAsc : IComparer<int[]>
    {
        public int Compare(int[] a, int[] b)
        {
            if (Sum(a) < Sum(b)) return 1;
            if (Sum(a) == Sum(b)) return 0;
            return -1;
        }
        public static int Sum(int[] Array)
        {
            int sum = 0;

            for (int i = 0; i < Array.Length; i++)
            {
                sum += Array[i];
            }
            return sum;
        }

    }
}
