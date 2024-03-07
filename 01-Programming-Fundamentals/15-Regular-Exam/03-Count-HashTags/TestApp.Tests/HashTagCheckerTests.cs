using NUnit.Framework;

namespace TestApp.Tests
{
    public class HashTagCheckerTests
    {
        [Test]
        public void Test_GetHashTags_ValidTextWithOneHashTag_ReturnMessageForOneHashTags()
        {
            // Arrange
            string text = "abcd#";
            string expectedResult = "Only one! You know exactly what you #tag.";

            // Act
            string result = HashTagChecker.GetHashTags(text);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Test_GetHashTags_ValidText_ReturnMessageForEvenHashTags()
        {
            // Arrange
            string text = "#abcd#";
            string expectedResult = "The text contains an even number of #tags (2 in total).";

            // Act
            string result = HashTagChecker.GetHashTags(text);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Test_GetHashTags_ValidText_ReturnMessageForOddHashTags()
        {
            // Arrange
            string text = "#abcd##";
            string expectedResult = "The text contains an odd number of #tags (3 in total).";

            // Act
            string result = HashTagChecker.GetHashTags(text);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Test_GetHashTags_NullOrEmptyText_ReturnsErrorMessage()
        {
            // Arrange
            string text = "";
            string expectedResult = "No content...";

            // Act
            string result = HashTagChecker.GetHashTags(text);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Test_GetHashTags_TestWithoutHashTags_ReturnsErrorMessage()
        {
            // Arrange
            string text = "abcd";
            string expectedResult = "The text does not contain #tags.";

            // Act
            string result = HashTagChecker.GetHashTags(text);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}

