using NUnit.Framework;
using System;
using static System.Net.Mime.MediaTypeNames;

namespace TestApp.Tests;

public class ExtractFileTests
{
    [Test]
    public void Test_GetFile_NullPath_ThrowsArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>(() => ExtractFile.GetFile(null));
    }

    [Test]
    public void Test_GetFile_EmptyPath_ThrowsArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>(() => ExtractFile.GetFile(string.Empty));
    }

    [Test]
    public void Test_GetFile_ValidPath_ReturnsFileNameAndExtension()
    {
        string result = ExtractFile.GetFile("C:\\Users\\John\\Documents\\example.txt");
        Assert.AreEqual(("File name: example\nFile extension: txt"), result);
    }

    [Test]
    public void Test_GetFile_PathWithNoExtension_ReturnsFileNameOnly()
    {
       string result = ExtractFile.GetFile("C:\\Users\\John\\Documents\\example");
        Assert.AreEqual(("File name: example"), result);
    }

    [Test]
    public void Test_GetFile_PathWithSpecialCharacters_ReturnsFileNameAndExtension()
    {
        string result = ExtractFile.GetFile("C:\\Users\\John\\Documents?\\example.txt");
        Assert.AreEqual(("File name: example\nFile extension: txt"), result);
    }
}
