using System.Linq;
using NUnit.Framework;

namespace KatasAndExercises.Algorithms
{
    public abstract class AbstractSortTester
    {
        protected ISorter Sorter { get; set; }

        [TestCase(new[] { 5, 2, 9, 7, 2 })]
        [TestCase(new[] { 9, 2 })]
        [TestCase(new[] { 5, 1222, 39, 7, 57, 0, 2 })]
        [TestCase(new[] { 5 })]
        [TestCase(new[] { 1, 2, 3, 4 })]
        public void Test(int[] input)
        {
            var expected = input.OrderBy(o => o);

            var actual = Sorter.Sort(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}