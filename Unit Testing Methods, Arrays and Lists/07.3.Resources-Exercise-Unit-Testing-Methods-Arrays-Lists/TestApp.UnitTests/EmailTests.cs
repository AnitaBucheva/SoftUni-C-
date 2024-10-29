using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailTests
{
 
    [Test]
    public void Test_IsValidEmail_ValidEmail()
    {
      
        // Act
        bool result = Email.IsValidEmail("test@example.com");
        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsValidEmail_InvalidEmail()
    {
        bool result = Email.IsValidEmail("invalid-email");
        Assert.IsFalse(result);
    }

    [Test]
    public void Test_IsValidEmail_NullInput()
    {
        bool result = Email.IsValidEmail(string.Empty);
        Assert.IsFalse(result);
    }
}
