using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    

    public static class Utils
    {
        private class Adaptor : IComparer<int[]>
        {
            Comparator del;

            public Adaptor(Comparator del)
            {
                this.del = del;
            }

            public int Compare(int[] a, int[] b)
            {
                return del(a, b);
            }
        }

        public delegate int Comparator(int[] a, int[] b);

        public static void BubbleSort(int[][] jaggedArray, Comparator comp)
        {
            if (jaggedArray == null || jaggedArray.Contains(null) || comp == null)
                throw new ArgumentNullException();
            BubbleSort(jaggedArray,new Adaptor(comp));       
        }
        public static void BubbleSort(int[][] jaggedArray, IComparer<int[]> comp)
        {
            if (jaggedArray == null || jaggedArray.Contains(null) || comp == null)
                throw new ArgumentNullException();

            for (int i = 0; i < jaggedArray.Length - 1; i++)
            {
                for (int j = 0; j < jaggedArray.Length - 1 - i; j++)
                {

                    if (comp.Compare(jaggedArray[j], jaggedArray[j + 1]) > 0)
                        Swap(ref jaggedArray[j], ref jaggedArray[j + 1]);
                }
            }
        }

        private static void Swap(ref int[] a, ref int[] b)
        {
            int[] x = a;
            a = b;
            b = x;
        }


    }


}
