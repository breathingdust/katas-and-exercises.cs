using NUnit.Framework;

namespace KatasAndExercises.Algorithms
{
    [TestFixture]
    class ReverseAnArray
    {
        /// <summary>
        /// Time: O(n/2)
        /// Space: O(1)
        /// </summary>
        [Test]
        public void Reverse()
        {
            var input = new[] { 'a', 'b', 'c', 'd' };
            var expected = new[] { 'd', 'c', 'b', 'a' };

            var current = 'a';

            for (int i = 0; i < input.Length/2; i++)
            {
                current = input[i];
                input[i] = input[input.Length - (i + 1)];
                input[input.Length - (i + 1)] = current;
            }

            Assert.That(input, Is.EqualTo(expected));
        }
    }
}
