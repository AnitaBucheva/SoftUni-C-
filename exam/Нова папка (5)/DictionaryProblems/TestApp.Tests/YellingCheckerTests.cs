using System;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace TestApp.Tests;

[TestFixture]
public class YellingCheckerTests
{
    [Test]
    public void Test_AnalyzeSentence_EmptyString_ReturnsEmptyDictionary()
    {
        // Arrange
        string input = "";

        // Act
        Dictionary<string, int> result = YellingChecker.AnalyzeSentence(input);

        // Assert
        Assert.IsEmpty(result);
    }

    [Test]
    public void Test_AnalyzeSentence_OnlyUpperCaseWords_ReturnsDictionaryWithYellingEntriesOnly()
    {
        // Arrange
        string input = "THIS IS SHOUTING";

        // Act
        Dictionary<string, int> result = YellingChecker.AnalyzeSentence(input);

        // Assert
        Assert.AreEqual(1, result.Count);
        Assert.IsTrue(result.ContainsKey("yelling"));
        Assert.AreEqual(3, result["yelling"]);
    }

    [Test]
    public void Test_AnalyzeSentence_OnlyLowerCaseWords_ReturnsDictionaryWithSpeakingLowerEntriesOnly()
    {
        // Arrange
        string input = "this is whispering";

        // Act
        Dictionary<string, int> result = YellingChecker.AnalyzeSentence(input);

        // Assert
        Assert.AreEqual(1, result.Count);
        Assert.IsTrue(result.ContainsKey("speaking lower"));
        Assert.AreEqual(3, result["speaking lower"]);
    }

    [Test]
    public void Test_AnalyzeSentence_OnlyMixedCaseWords_ReturnsDictionaryWithASpeakingNormalEntriesOnly()
    {
        // Arrange
        string input = "This Is Normal";

        // Act
        Dictionary<string, int> result = YellingChecker.AnalyzeSentence(input);

        // Assert
        Assert.AreEqual(1, result.Count);
        Assert.IsTrue(result.ContainsKey("speaking normal"));
        Assert.AreEqual(3, result["speaking normal"]);
    }

    [Test]
    public void Test_AnalyzeSentence_LowerUpperMixedCasesWords_ReturnsDictionaryWithAllTypeOfEntries()
    {
        // Arrange
        string input = "this IS a Mix";

        // Act
        Dictionary<string, int> result = YellingChecker.AnalyzeSentence(input);

        // Assert
        Assert.AreEqual(3, result.Count);
        Assert.AreEqual(2, result["speaking lower"]);
        Assert.AreEqual(1, result["yelling"]);
        Assert.AreEqual(1, result["speaking normal"]);
    }
}

