using System;
using System.Text;
using System.Linq;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestApp.Tests;

[TestFixture]
public class StringLengthCalculatorTests
{
    [Test]
    public void Test_Calculate_EmptyString_ReturnsZero()
    {
        var calculator = new StringLengthCalculator();
        var input = "";

        // Act
        var result = StringLengthCalculator.Calculate(input);

        // Assert
        Assert.AreEqual(0, result);
    }

    [Test]
    public void Test_Calculate_SingleEvenLengthWord_ReturnsCorrectInteger()
    {
        var calculator = new StringLengthCalculator();
        var input = "test"; // Length is 4 (even)

        // Act
        var result = StringLengthCalculator.Calculate(input);

        // Assert
        Assert.AreEqual(896, result);

    }

    [Test]
    public void Test_Calculate_SingleOddLengthWord_ReturnsCorrectInteger()
    {
        var calculator = new StringLengthCalculator();
        var input = "hello"; // Length is 5 (odd)

        // Act
        var result = StringLengthCalculator.Calculate(input);

        // Assert
        Assert.AreEqual(266, result);
    }

    [Test]
    public void Test_Calculate_WholeSentenceString_ReturnsCorrectInteger()
    {
        var calculator = new StringLengthCalculator();
        var input = "This is a test sentence."; // Length is 24 including spaces and punctuation

        // Act
        var result = StringLengthCalculator.Calculate(input);

        // Assert
        Assert.AreEqual(4400, result);
    }

}

