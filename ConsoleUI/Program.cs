using System;
using Logic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[5][];
            jaggedArray[0] = new int[] { 7, 9, 3, 10, 4, 15 };
            jaggedArray[1] = new int[] { 3,1000};
            jaggedArray[2] = new int[] { 5, -2, 9, 12000 };
            jaggedArray[3] = new int[] { 1, 2, 7, 0, -1 };
            jaggedArray[4] = new int[] { 1, 2};

            Utils.Choice(jaggedArray, Utils.Sum,0);
            Utils.Print(jaggedArray);
            
            Console.ReadKey();

        }
    }
}
