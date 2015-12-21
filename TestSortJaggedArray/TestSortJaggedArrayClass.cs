using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Logic;
using static Logic.Utils;

namespace TestSortJaggedArray

{
    public class Adaptor : IComparer<int[]>
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

    [TestFixture]
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
            IComparer<int[]> comp = new ComparatorMaxElementAsc();
            Comparator del = comp.Compare;

            Utils.SortWhithInterface(jaggedArray, new Adaptor(del));
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
            IComparer<int[]> comp = new ComparatorMaxElementDesc();
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

            IComparer<int[]> comp = new ComparatorSumAsc();

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

            IComparer<int[]> comp = new ComparatorSumDesc();

            Utils.SortWhithInterface(jaggedArray, comp);
            CollectionAssert.AreEqual(expected, jaggedArray);




        }
        #endregion Test_BySum

        #region Delegate_Asc
        [Test, TestCaseSource(nameof(TestDataMaxAsc))]
        public static void SortJaggedArray_Method_Test_Max_Asc_Delegate(int[][] jaggedArray,int[][] expected)
        {
            ComparatorMaxElementAsc obj = new ComparatorMaxElementAsc();
            Comparator comp = obj.Compare;

            Utils.SortWithDelegate(jaggedArray, comp);
            CollectionAssert.AreEqual(expected, jaggedArray);

        }

        #endregion Delegate_Asc
        #region Delegate_Desc
        [Test, TestCaseSource(nameof(TestDataMaxDesc))]
        public static void SortJaggedArray_Method_Test_Max_Desc_Delegate(int[][] jaggedArray, int[][] expected)
        {
            ComparatorMaxElementAsc obj = new ComparatorMaxElementAsc();
            Comparator comp = obj.Compare;

            Utils.SortWithDelegate(jaggedArray, comp);
            CollectionAssert.AreEqual(expected, jaggedArray);

        }
        #endregion Delegate_Desc

        #region Exception_Test
        public IEnumerable<TestCaseData> TestEcseption
        {
            get
            {
                yield return new TestCaseData(null, new ComparatorMaxElementAsc()).Throws(typeof(ArgumentNullException));

            }

        }
        
        [Test,TestCaseSource(nameof(TestEcseption))]

        public static void SortJaggedArray_Exseptions_Test(int[][]jaggedArray, IComparer<int[]>comp)
        {
            Utils.SortWhithInterface(jaggedArray, comp);

        }
        #endregion Exseption_Test
    }
}