using NUnit.Framework;

namespace mybrainhurts.Katas.KarateChop.August2016
{
    public class BinarySearchTester : AbstractBinarySearchTester
    {
        [SetUp]
        public void SetUp()
        {
            BinarySearch = new BinarySearch();
        }
    }

    public class RecursiveBinarySearchTester : AbstractBinarySearchTester
    {
        [SetUp]
        public void SetUp()
        {
            BinarySearch = new RecursiveBinarySearch();
        }
    }
}