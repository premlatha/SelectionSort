using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SelectionSort.Test
{
    [TestFixture]
    public class SelectionSortTest
    {
        [Test]
        public void PerformSort()
        {
            int[] unsortedArr = { 66, 34, 1, 90, 88 };
            int[] actualSortedArr = { 1,34,66,88,90};
            int[] expectedSortedArr = Program.PerformSelectionSort(unsortedArr);
            Assert.AreEqual(expectedSortedArr, actualSortedArr, "Array is sorted");
        }

    }
}
