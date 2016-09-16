using NUnit.Framework;

namespace KatasAndExercises.Algorithms
{
    [TestFixture]
    public class PalindromeTest
    {
        public bool IsAPalindrome(string input)
        {
            if (input.Length == 0 || input.Length == 1)
            {
                return true;
            }
            if (input[0] != input[input.Length - 1])
            {
                return false;
            }
            return IsAPalindrome(input.Substring(1, input.Length - 2));
        }


        [TestCase("gh")]
        [TestCase("palindrome")]
        public void not_a_palindrome(string input)
        {
            Assert.That(IsAPalindrome(input), Is.False);
        }

        [TestCase("racecar")]
        [TestCase("rotor")]
        [TestCase("n")]
        [TestCase("")]
        public void totally_a_palindrome(string input)
        {
            Assert.That(IsAPalindrome(input), Is.True);
        }
    }
}
