﻿using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    [Test]
    public void Test_SortInPattern_SortsIntArrayInPattern_SortsCorrectly()
    {
        //Arrange
        int[] input = new int[] { 1, 2, 1, 3, 4, 10, 12, 15 };
        //Act
        int[] result = Pattern.SortInPattern(input);
        //Assert
        Assert.That(result, Is.EqualTo(new[] {1, 15, 2, 12, 3, 10, 4}));
    }

    [Test]
    public void Test_SortInPattern_EmptyArray_ReturnsEmptyArray()
    {
        //Arrange
        int[] input = Array.Empty<int>();
        //Act
        int[] result = Pattern.SortInPattern(input);
        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_SortInPattern_SingleElementArray_ReturnsSameArray()
    {
        //Arrange
        int[] input = new int[] { 1 };
        //Act
        int[] result = Pattern.SortInPattern(input);
        //Assert
        Assert.That(result, Is.EqualTo(new[] { 1 }));
    }
}
