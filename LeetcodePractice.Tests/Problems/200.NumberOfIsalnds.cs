using Xunit;
using Problems;

public class NumberOfIslands
{
    [Fact]
    public void TestNumberOfIslands()
    {
        // Arrange
        var problem = new NumberOfIslands200();

        // Act
        var result1 = problem.NumIslands(new char[][] { new char[] { '1', '1', '1', '1', '0' }, new char[] { '1', '1', '0', '1', '0' }, new char[] { '1', '1', '0', '0', '0' }, new char[] { '0', '0', '0', '0', '0' } });

        // Assert
        Assert.Equal(1, result1);
    }
}
