using NUnit.Framework;

namespace KatasAndExercises.Algorithms
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