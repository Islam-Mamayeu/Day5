using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Logic;
namespace TestSortJaggedArray

{[TestFixture]
    public class TestSortJaggedArrayClass
    {

        #region Test_ByMaxElement
        public IEnumerable<TestCaseData> TestDataMaxAsc
        {
            get
            {
                yield return new TestCaseData(
                    new int[][] {
                        new int[] { 7, 3, 7, 2,1000 },
                        new int[] { 8, 1 },
                        new int[] { 4, 6, 9 } },

                    new int[][] {
                        new int[] { 8, 1 },
                        new int[] { 4, 6, 9 },
                        new int[] { 7, 3, 7, 2,1000 } });
            }
        }

        [Test, TestCaseSource(nameof(TestDataMaxAsc))]

        public static void SortJaggedArray_Method_Test_SumAsc(int[][] jaggedArray, int[][] expected)
        {
            IJaggedArraySortComparer comp = new ComparatorMaxElementAsc();
            Utils.SortWhithInterface(jaggedArray, comp);
            CollectionAssert.AreEqual(expected, jaggedArray);
        }

        public IEnumerable<TestCaseData> TestDataMaxDesc
        {
            get
            {
                yield return new TestCaseData(
                    new int[][] {
                        new int[] { -1, -5,-100 },
                        new int[] { 16, 17, -5, 2 },
                        new int[] { 1, 1, 1} },

                    new int[][] {
                        new int[] {  16, 17, -5, 2  },
                        new int[] {  1, 1, 1},
                        new int[] { -1, -5,-100} });

            }
        }

        [Test, TestCaseSource(nameof(TestDataMaxDesc))]
        public static void SortJaggedArray_Method_Test_SumDesc(int[][] jaggedArray, int[][] expected)
        {
            IJaggedArraySortComparer comp = new ComparatorMaxElementDesc();
            Utils.SortWhithInterface(jaggedArray, comp);
            CollectionAssert.AreEqual(expected, jaggedArray);
        }


        #endregion Test_ByMaxElement

        #region Test_BySum
        public IEnumerable<TestCaseData> TestDataSumAsc
        {
            get
            {
                yield return new TestCaseData(
                    new int[][] {
                        new int[] { 7, 3, 7, 2,1000 },
                        new int[] { 8, 1 },
                        new int[] { 4, 6, 9 } },

                    new int[][] {
                        new int[] { 8, 1 },
                        new int[] { 4, 6, 9 },
                        new int[] { 7, 3, 7, 2,1000 } });
            }

        }
        [Test, TestCaseSource(nameof(TestDataSumAsc))]
        public static void SortJaggedArray_Method_Test_Max_Asc(int[][] jaggedArray, int[][] expected)
        {

            IJaggedArraySortComparer comp = new ComparatorSumAsc();

            Utils.SortWhithInterface(jaggedArray, comp);
            CollectionAssert.AreEqual(expected, jaggedArray);


        }

    
    public IEnumerable<TestCaseData> TestDataSumDesc
    {
        get
        {
            yield return new TestCaseData(
                new int[][] {
                        new int[] { 7, 1000 },
                        new int[] { 8, 1 },
                        new int[] { 4, 6, 9000 } },

                new int[][] {
                        new int[] { 8, 1 },
                        new int[] { 4, 6, 9 },
                        new int[] { 7, 3, 7, 2,1000 } });
        }

    }
    [Test, TestCaseSource(nameof(TestDataSumDesc))]
    public static void SortJaggedArray_Method_Test_Max_Desc(int[][] jaggedArray, int[][] expected)
    {

        IJaggedArraySortComparer comp = new ComparatorSumDesc();

        Utils.SortWhithInterface(jaggedArray, comp);
        CollectionAssert.AreEqual(expected, jaggedArray);


    }

}


    #endregion Test_BySum
}