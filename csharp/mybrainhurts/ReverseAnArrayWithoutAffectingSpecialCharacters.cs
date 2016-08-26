using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace mybrainhurts
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
        [Test]
        public void ReverseWithoutAffectingSpecialCharacters()
        {
            var input = "a,b$c".ToCharArray();
            var expected = "c,b$a";

            var forwardIndex = 0;
            var reverseIndex = input.Length - 1;

            for (var i = 0; i < input.Length; i++){
                var current = input[i];
                if (!IsASpecialCharacter(input[forwardIndex]) && !IsASpecialCharacter(input[reverseIndex]))
                {

                }
            }

            var actual = new string(input);

            Assert.That(actual, Is.EqualTo(expected));
        }

        public bool IsASpecialCharacter(char character)
        {
            var regex = new Regex(@"^\w+$");
            return regex.IsMatch(character.ToString());
        }
    }

    // iterate
    // if the current is a special character
}
