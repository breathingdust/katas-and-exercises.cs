using NUnit.Framework;

namespace mybrainhurts.Katas.KarateChop.August2016
{
    [TestFixture]
    public abstract class AbstractBinarySearchTester
    {
        protected IBinarySearch BinarySearch { get;set;}

        [TestCase(-1, 3, new int[0])]
        [TestCase(-1, 3, new[] {1})]
        [TestCase(0, 1, new[] {1})]
        public void TestChopOne(int expected, int target, int[] input)
        {
            TestIt(expected, target, input);
        }

        [TestCase(0, 1, new int[] {1, 3, 5})]
        [TestCase(1, 3, new int[] {1, 3, 5})]
        [TestCase(2, 5, new int[] {1, 3, 5})]
        [TestCase(-1, 0, new int[] {1, 3, 5})]
        [TestCase(-1, 2, new int[] {1, 3, 5})]
        [TestCase(-1, 4, new int[] {1, 3, 5})]
        [TestCase(-1, 6, new int[] {1, 3, 5})]
        public void TestChopTwo(int expected, int target, int[] input)
        {
            TestIt(expected, target, input);
        }

        [TestCase(0, 1, new int[] {1, 3, 5, 7})]
        [TestCase(1, 3, new int[] {1, 3, 5, 7})]
        [TestCase(2, 5, new int[] {1, 3, 5, 7})]
        [TestCase(3, 7, new int[] {1, 3, 5, 7})]
        [TestCase(-1, 0, new int[] {1, 3, 5, 7})]
        [TestCase(-1, 2, new int[] {1, 3, 5, 7})]
        [TestCase(-1, 4, new int[] {1, 3, 5, 7})]
        [TestCase(-1, 6, new int[] {1, 3, 5, 7})]
        [TestCase(-1, 8, new int[] {1, 3, 5, 7})]
        public void TestChopThree(int expected, int target, int[] input)
        {
            TestIt(expected, target, input);
        }

        private void TestIt(int expected, int target, int[] input)
        {
            var result = BinarySearch.Search(target, input);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}