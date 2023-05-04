using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)] // ← you will need to put some test data and expected result here.
        [InlineData("car", false)]
        [InlineData("hanna",false)]
        [InlineData("Elle", true)]
        [InlineData("Neven", true)]
        public void IsAPalindrome(string nameHolder, bool expected)
        {
            // Arrange
            var challenger = new WordSmith();

            // Act
            bool actual = challenger.IsAPalindrome(nameHolder);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
