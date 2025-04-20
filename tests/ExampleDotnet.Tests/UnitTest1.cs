namespace ExampleDotnet.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // Arrange
        int a = 5;
        int b = 3;
        int expected = 8;

        // Act
        int result = Calculator.Calc.Add(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test2()
    {
        // Arrange
        int a = 5;
        int b = 3;
        int expected = 2;

        // Act
        int result = Calculator.Calc.Subtract(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test3()
    {
        // Arrange
        int a = 5;
        int b = 3;
        int expected = 15;

        // Act
        int result = Calculator.Calc.Multiply(a, b);

        // Assert
        Assert.Equal(expected, result);
    }
}
