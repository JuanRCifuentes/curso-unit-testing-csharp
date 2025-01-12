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
    
    [Fact]
    public void QuantityInWords()
    {
        // Arrange
        // var strOperations = new StringOperations();
        // Act
        var result = _strOperations.QuantityInWords("cat", 10);
        // Assert
        Assert.StartsWith("ten", result);
        Assert.Contains("cat", result);
    }
    
    [Fact]
    public void GetStringLength()
    {
        // Arrange
        // var strOperations = new StringOperations();
        // Act
        Assert.ThrowsAny<ArgumentNullException>(() => _strOperations.GetStringLength(null));
        var result = _strOperations.GetStringLength("uno");
        // Assert
        Assert.Equal(3, result);
    }
    
    [Fact]
    public void CountOccurrences()
    {
        // Arrange
        // var mockLogger = new Mock<ILogger<StringOperations>>();
        var mockLogger = new Mock<ILogger<StringOperations>>();
        var strOperations = new StringOperations(mockLogger.Object);
        // Act
        var result = strOperations.CountOccurrences("Hello Platzi", 'l');
        // Assert
        Assert.Equal(3, result);
    }
    
    [Theory]
    [InlineData("V", 5)]
    [InlineData("III", 3)]
    [InlineData("X", 10)]
    public void FromRomanToNumber(string romanNumber, int expected)
    {
        // Arrange
        // var strOperations = new StringOperations();
        // Act
        var result = _strOperations.FromRomanToNumber(romanNumber);
        // Assert
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void ReadFile()
    {
        // Arrange
        var strOperations = new StringOperations();
        var mockFileReader = new Mock<IFileReaderConector>();
        mockFileReader.Setup(p => p.ReadString(It.IsAny<string>())).Returns("Reading File");
        // Act
        var result = strOperations.ReadFile(mockFileReader.Object, "file.txt");
        // Assert
        Assert.Equal("Reading File", result);
    }
}