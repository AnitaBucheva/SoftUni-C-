using NUnit.Framework;
using System;

using System.Collections.Generic;

namespace TestApp.Tests;

public class DrumSetTests
{
    [Test]
    public void Test_Drum_TerminateCommandNotGiven_ThrowsArgumentException()
    {
        decimal money = 100m;
        List<int> qualities = new List<int> { 10, 15, 20 };
        List<string> commands = new List<string> { "5", "10" };

        var ex = Assert.Throws<ArgumentException>(() => DrumSet.Drum(100, qualities, commands));
  
    }

    [Test]
    public void Test_Drum_StringGivenAsCommand_ThrowsArgumentException()
    {
        decimal money = 100m;
        List<int> qualities = new List<int> { 10, 15, 20 };
        List<string> commands = new List<string> { "5", "10", "Invalid", "Hit it again, Gabsy!" };

        var ex = Assert.Throws<ArgumentException>(() => DrumSet.Drum(money, qualities, commands));
    }

    [Test]
    public void Test_Drum_ReturnsCorrectQualityAndAmount()
    {
        decimal money = 100;
        List<int> qualities = new List<int> { 10, 15, 20 };
        List<string> commands = new List<string> { "10", "Hit it again, Gabsy!" };
        string ex = "10 5 10\nGabsy has 70.00lv.";
        var result = DrumSet.Drum(money, qualities, commands);
       
        Assert.AreEqual(ex, result);
    }

    [Test]
    public void Test_Drum_BalanceZero_WithOneDrumLeftOver_ReturnsCorrectQualityAndAmount()
    {
        decimal money = 0;
        List<int> qualities = new List<int> { 10, 15, 20 };
        List<string> commands = new List<string> { "10", "Hit it again, Gabsy!" };
        string ex = "5 10\nGabsy has 0.00lv.";
        var result = DrumSet.Drum(money, qualities, commands);

        Assert.AreEqual(ex, result);
    }

    [Test]
    public void Test_Drum_NotEnoughBalance_RemovesAllDrums_ReturnsCorrectQualityAndAmount()
    {
        decimal money = 5;
        List<int> qualities = new List<int> { 10, 15, 20 };
        List<string> commands = new List<string> { "10", "Hit it again, Gabsy!" };
        string ex = "5 10\nGabsy has 5.00lv.";
        var result = DrumSet.Drum(money, qualities, commands);

        Assert.AreEqual(ex, result);
    }
}
