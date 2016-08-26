using System;
using System.Collections.Generic;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace mybrainhurts
{
    [TestFixture]
    class CountTripletsWithSumSmallerThanAGivenValue
    {
        [TestCase(new[] {-2, 0, 1, 3}, 2, 2)]
        [TestCase(new[] { 5, 1, 3, 4, 7 }, 12, 4)]
        public void CountTriplets(int[] input, int threshold, int expected)
        {
            var actual = DoTheThing(input, threshold);

            Assert.That(actual, Is.EqualTo(expected));
        }

        /// <summary>
        /// Time: O(n^3)
        /// Space: O(n)
        /// </summary>
        private static int DoTheThing(int[] input, int threshold)
        {
            var result = 0;
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    for (int k = j + 1; k < input.Length; k++)
                    {
                        var sum = input[i] + input[j] + input[k];
                        Console.WriteLine($"{input[i]}+{input[j]}+{input[k]}={sum}");
                        if (sum < threshold)
                        {
                            result++;
                        }
                    }
                }
            }
            return result;
        }
    }
}
