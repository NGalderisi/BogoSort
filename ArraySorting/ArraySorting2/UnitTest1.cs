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
        
    }
}
