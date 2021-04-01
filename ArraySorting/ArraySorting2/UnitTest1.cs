using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArraySorting;


namespace ArraySortingTests
{
    [TestClass]
    public class ArraySortingTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] testnumbers = { 7, 2, 1, 5 };
            int[] expectedresult = { 1, 2, 5, 7 };
;           int[] sortedtest = Program.BogoSort(testnumbers);
            CollectionAssert.AreEqual(expectedresult, sortedtest);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int[] testnumbers = { 0, 2, 1 };
            int[] expectedresult = { 0, 1, 2 };
            int[] sortedtest = Program.BogoSort(testnumbers);
            CollectionAssert.AreEqual(expectedresult, sortedtest);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int[] testnumbers = { 1, 0, -1 };
            int[] expectedresult = { -1, 0, 1 };
            int[] sortedtest = Program.BogoSort(testnumbers);
            CollectionAssert.AreEqual(expectedresult, sortedtest);
        }
    }
}
