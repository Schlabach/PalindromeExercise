using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("spaceship", false)]
        [InlineData("Racecar", true)]


        public void PalidromeTest(string word, bool expected)
        {
            var test = new WordSmith();

            var actual = test.IsAPalindrome(word);

            Assert.Equal(expected, actual); 
        }
    }
}
