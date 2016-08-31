using NUnit.Framework;

namespace mybrainhurts.Algorithms
{
    public class BubbleSortTests : AbstractSortTester
    {
        [SetUp]
        public void SetUp()
        {
            Sorter = new BubbleSort();
        }
    }

    public class InsertionSortTests : AbstractSortTester
    {
        [SetUp]
        public void SetUp()
        {
            Sorter = new InsertionSort();
        }
    }
}