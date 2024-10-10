using NUnit.Framework;

namespace TestApp.UnitTests;

public class StringReverseTests
{
    // TODO: finish test
    [Test]
    public void Test_Reverse_WhenGivenEmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input  = string.Empty;

        string actual = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual("", actual);
    }

    [Test]
    public void Test_Reverse_WhenGivenSingleCharacterString_ReturnsSameCharacter()
    {
        string input = "X";

        // Act
        string result = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual("X", result);
        Assert.AreEqual(1, result.Length);
    }

    [Test]
    public void Test_Reverse_WhenGivenNormalString_ReturnsReversedString()
    {
        string input = "XYZ";

        // Act
        string result = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual(input.Length, result.Length);
        Assert.AreEqual("ZYX", result);
    }
}
