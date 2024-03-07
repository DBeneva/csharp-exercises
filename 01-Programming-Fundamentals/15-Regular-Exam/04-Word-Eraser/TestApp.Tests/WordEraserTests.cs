using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TestApp.Tests;

public class WordEraserTests
{
    [Test]
    public void Test_Erase_EmptyWordsList_ShouldReturnEmptyString()
    {
        // Arrange
        WordEraser wordEraser = new WordEraser();
        List<string> words = new List<string>();
        string expectedResult = string.Empty;

        // Act
        string result = wordEraser.Erase(words, "aa");

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Erase_NullWordsList_ShouldReturnEmptyString()
    {
        // Arrange
        WordEraser wordEraser = new WordEraser();
        List<string> words = null;
        string expectedResult = string.Empty;

        // Act
        string result = wordEraser.Erase(words, "aa");

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Erase_NullOrEmptyWordToErase_ShouldReturnStringOfGivenWordsList()
    {
        // Arrange
        WordEraser wordEraser = new WordEraser();
        List<string> words = new List<string>() { "aa", "bb", "cc" };
        string expectedResult = "aa bb cc";

        // Act
        string result = wordEraser.Erase(words, "");

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Erase_ValidInput_ShouldReturnEmptyString_WhenAllWordsMatchedTheWordToErase()
    {
        // Arrange
        WordEraser wordEraser = new WordEraser();
        List<string> words = new List<string>() { "aa", "aa", "aa" };
        string expectedResult = String.Empty;

        // Act
        string result = wordEraser.Erase(words, "aa");

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Erase_ValidInput_ShouldReturnStringWithoutErasedWords_WhenFewOfWordsMatchedWordToArese()
    {
        // Arrange
        WordEraser wordEraser = new WordEraser();
        List<string> words = new List<string>() { "aa", "bb", "cc" };
        string expectedResult = "aa cc";

        // Act
        string result = wordEraser.Erase(words, "bb");

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}

