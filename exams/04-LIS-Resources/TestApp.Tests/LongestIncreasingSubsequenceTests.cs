using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class LongestIncreasingSubsequenceTests
{
    [Test]
    public void Test_GetLis_NullArray_ThrowsArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>(() => LongestIncreasingSubsequence.GetLis(null));
    }

    [Test]
    public void Test_GetLis_EmptyArray_ReturnsEmptyString()
    {
        string result = LongestIncreasingSubsequence.GetLis(new int[] { });
        Assert.AreEqual(string.Empty, result);
    }

    [Test]
    public void Test_GetLis_SingleElementArray_ReturnsElement()
    {
        string result = LongestIncreasingSubsequence.GetLis(new int[] { 10 });
        Assert.AreEqual("10", result);
    }

    [Test]
    public void Test_GetLis_UnsortedArray_ReturnsLongestIncreasingSubsequence()
    {
        string result = LongestIncreasingSubsequence.GetLis(new int[] { 10, 22, 9, 33, 21, 50, 41, 60, 80 });
        Assert.AreEqual("10 22 33 50 60 80", result);
    }

    [Test]
    public void Test_GetLis_SortedArray_ReturnsItself()
    {
        string result = LongestIncreasingSubsequence.GetLis(new int[] { 1, 2, 3, 4, 5 });
        Assert.AreEqual("1 2 3 4 5", result);
    }
}
