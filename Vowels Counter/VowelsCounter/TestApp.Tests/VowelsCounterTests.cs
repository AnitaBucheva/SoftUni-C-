using System;
using System.Text;
using System.Linq;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestApp.Tests
{
    public class VowelsCounterTests
    {
        [Test]
        public void Test_CountTotalVowels_GetEmptyList_ReturnsZero()
        {
            // Arrange
            List<string> input = new List<string>();

            // Act
            int result = VowelsCounter.CountTotalVowels(input);

            // Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Test_CountTotalVowels_GetListWithEmptyStringValues_ReturnsZero()
        {
            // Arrange
            List<string> input = new List<string> { "", "", "" };

            // Act
            int result = VowelsCounter.CountTotalVowels(input);

            // Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Test_CountTotalVowels_MultipleLowerCaseStrings_ReturnsVowelsCount()
        {
            // Arrange
            List<string> input = new List<string> { "hello", "world", "programming", "vowels" };

            // Act
            int result = VowelsCounter.CountTotalVowels(input);

            // Assert
            Assert.AreEqual(8, result); // "hello" -> 2, "world" -> 1, "programming" -> 3, "vowels" -> 1
        }

        [Test]
        public void Test_CountTotalVowels_GetStringsWithNoVowels_ReturnsZero()
        {
            // Arrange
            List<string> input = new List<string> { "rhythm", "bcdfghjklmnpqrstvwxyz", "gym" };

            // Act
            int result = VowelsCounter.CountTotalVowels(input);

            // Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Test_CountTotalVowels_StringsWithMixedCaseVowels_ReturnsVowelsCount()
        {
            // Arrange
            List<string> input = new List<string> { "HELLO", "world", "PrOgRaMmInG", "Vowels" };

            // Act
            int result = VowelsCounter.CountTotalVowels(input);

            // Assert
            Assert.AreEqual(8, result); // "HELLO" -> 2, "world" -> 1, "PrOgRaMmInG" -> 4, "Vowels" -> 3
        }
    }
}

