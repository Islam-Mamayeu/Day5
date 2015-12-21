using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public static class Utils
    {
        public delegate int Comparator(int[] a, int[] b);
       
        public static void SortWithDelegate(int[][] jaggedArray, Comparator comp)
        {
            for (int i = 0; i < jaggedArray.Length-1 ; i++)
            {
                for (int j = 0; j < jaggedArray.Length - 1 - i; j++)
                {
                    if(comp.Invoke(jaggedArray[j],jaggedArray[j + 1])>0)
                        Sort(jaggedArray,j);
                }
            }
        }
        public static void SortWhithInterface(int[][] jaggedArray, IJaggedArraySortComparer comp)
        {
            if (jaggedArray == null || jaggedArray.Contains(null) || comp == null)
                throw new ArgumentNullException();

            for (int i = 0; i < jaggedArray.Length - 1; i++)
            {
                for (int j = 0; j < jaggedArray.Length - 1 - i; j++)
                {

                    if( comp.Compare(jaggedArray[j],jaggedArray[j + 1])>0)
                       Sort(jaggedArray, j);                 
                }
            }
        }
        public static int Sum(int[] Array)
        {
            int sum=0;

            for(int i=0;i<Array.Length;i++)
            {
                sum += Array[i];
            }
            return sum;
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
        public static int Min(int[] Array)
        {
            int min = Array[0];
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] < min)
                    min = Array[i];
            }
            return min;
        }
        public static void Print(int[][]jaggedArray)
        {
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                int[] innerArray = jaggedArray[i];
                for (int a = 0; a < innerArray.Length; a++)
                {
                    Console.Write(innerArray[a] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void Sort(int[][] jaggedArray, int j)
        {
            int[] x = jaggedArray[j];
            jaggedArray[j] = jaggedArray[j + 1];
            jaggedArray[j + 1] = x;
        }


    }


}
