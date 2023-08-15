namespace StringManipulation.Tests;

public class StringManipulationTest
{
    [Fact]
    public void ConcatenateStrings()
    {
        var strOperations = new StringOperations();
        var result = strOperations.ConcatenateStrings("Hello", "Platzi");
        Assert.Equal("Hello Platzi", result);
    }
}