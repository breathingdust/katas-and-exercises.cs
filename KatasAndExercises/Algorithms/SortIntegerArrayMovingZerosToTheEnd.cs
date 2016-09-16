using NUnit.Framework;

namespace KatasAndExercises.Algorithms
{
    /// <summary>
    /// For a given list of integers, sort the list from least to greatest with the zeros at the end.
    /// </summary>
    [TestFixture]
    class SortIntegerArrayMovingZerosToTheEnd
    {
        [Test]
        public void Sort()
        {
            var input = new int[] {1,3,0,0,7,0,9,11,0,122,0 };
            var expected = new int[] { 1, 3, 7, 9, 11, 122, 0, 0, 0, 0, 0 };

            var sorter = new ZeroSorter();

            var actual = sorter.Sort(input);

            Assert.That(actual, Is.EqualTo(expected));
        }

        //keep track of the number of non-zero numbers
        //iterate through the list
        //for each item in the list
        //  if the item is not equal to zero
        //    set the value of the array whose index is the number of non-zero numbers and set it to the current number
        //    increment the number of non-zero numbers
        //  after the loop has finished, set the rest of the entries to zero (= number of zeros)

        // Time: Linear O(n)
        // Space: O(1)

        private class ZeroSorter
        {

            public int[] Sort(int[] arr)
            {
                int current = 0;
                for (int i = 0; i < arr.Length; i++)
                    if (arr[i] != 0)
                        arr[current++] = arr[i];
                while (current < arr.Length)
                    arr[current++] = 0;
                return arr;
            }
        }
    }
}
