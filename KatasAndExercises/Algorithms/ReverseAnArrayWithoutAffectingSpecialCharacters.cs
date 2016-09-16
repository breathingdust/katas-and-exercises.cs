using System.Text.RegularExpressions;
using NUnit.Framework;

namespace KatasAndExercises.Algorithms
{
    /// <summary>
    /// Given a string that contains special characters together with letter characters, reverse the contents of the array
    /// so that the special characters do not move.
    /// 
    /// Input: "a,b$c"
    /// Output: "c,b$a"
    /// </summary>
    [TestFixture]
    public class ReverseAnArrayWithoutAffectingSpecialCharacters
    {
        /// <summary>
        /// If both positions are non special then swap
        /// if the first position is special and the last is not increment first position
        /// if the first position is non-special and the last is special then increment last position
        /// if both are special then increment both
        /// 
        /// Time: O(n) Space: O(1)
        /// </summary>

        [TestCase("a,b$c", "c,b$a")]
        [TestCase("ab,c$d", "dc,b$a")]
        [TestCase("#$%^", "#$%^")]
        [TestCase("abcd", "dcba")]
        public void ReverseWithoutAffectingSpecialCharacters(string input, string expected)
        {
            var inputArray = input.ToCharArray();

            var forwardIndex = 0;
            var reverseIndex = inputArray.Length - 1;

            while (forwardIndex < reverseIndex)
            {
                if (!IsASpecialCharacter(inputArray[forwardIndex]) && !IsASpecialCharacter(inputArray[reverseIndex]))
                {
                    var first = inputArray[forwardIndex];
                    inputArray[forwardIndex] = inputArray[reverseIndex];
                    inputArray[reverseIndex] = first;
                    forwardIndex++;
                    reverseIndex--;
                }
                else
                {
                    if (IsASpecialCharacter(inputArray[forwardIndex]))
                    {
                        forwardIndex++;
                    }

                    if (IsASpecialCharacter(inputArray[reverseIndex]))
                    {
                        reverseIndex--;
                    }
                }
            }

            var actual = new string(inputArray);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void matches_a_special_character()
        {
            char input = '%';

            Assert.That(IsASpecialCharacter(input), Is.True);
        }

        [Test]
        public void does_not_match_a_special_character()
        {
            char input = 'a';

            Assert.That(IsASpecialCharacter(input), Is.False);
        }

        public bool IsASpecialCharacter(char character)
        {
            var regex = new Regex(@"^\w+$");
            return !regex.IsMatch(character.ToString());
        }
    }

    // iterate
    // if the current is a special character
}
