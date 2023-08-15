namespace StringManipulation.Tests;

public class StringManipulationTest
{
    private StringOperations _strOperations = new();
    
    [Fact]
    public void ConcatenateStrings()
    {
        // Arrange
        // var strOperations = new StringOperations();
        // Act
        var result = _strOperations.ConcatenateStrings("Hello", "Platzi");
        // Assert
        Assert.NotNull(result);
        Assert.NotEmpty(result);
        Assert.Equal("Hello Platzi", result);
    }

    [Fact]
    public void IsPalindrome_True()
    {
        // Arrange
        // var strOperations = new StringOperations();
        // Act
        var result = _strOperations.IsPalindrome("ama");
        // Assert
        Assert.True(result);
    }
    [Fact]
    public void IsPalindrome_False()
    {
        // Arrange
        // var strOperations = new StringOperations();
        // Act
        var result = _strOperations.IsPalindrome("Hello");
        // Assert
        Assert.False(result);
    }

    [Fact]
    public void RemoveWhitespace()
    {
        // Arrange
        // var strOperations = new StringOperations();
        // Act
        var result = _strOperations.RemoveWhitespace(" jfdskl fds f ds fdsa f dsaf sad fds ");
        // Assert
        Assert.Equal("jfdsklfdsfdsfdsafdsafsadfds", result);
    }
}