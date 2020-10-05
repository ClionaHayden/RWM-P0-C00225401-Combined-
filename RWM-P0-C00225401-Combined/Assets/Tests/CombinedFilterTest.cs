using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class CombinedFilterTest
    {
        [Test]
        public void CombinedFilterSimple()
        {
            int[] input = { 4, 2, 8, 3, 9, 4, 10 };
            int[] output = CombinedFilter.combinedFilter(input);
            int[] expected = { 24, 1, 40320, 5, 362880, 24, 3628800 };

            CollectionAssert.AreEqual(expected, output);
        }
    }
}

