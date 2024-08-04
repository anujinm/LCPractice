using Xunit;
using Problems;

public class TestMaximumPopulationYear1854
{
    [Fact]
    public void TestMaximumPopulationYear()
    {
        // Arrange
        var problem = new MaximumPopulationYear1854();
        
        // Act
        var result1 = problem.MaximumPopulation(new int[][] { new int[] {1993,1999}, new int[] {2000,2010} });
        var result2 = problem.MaximumPopulation(new int[][] { new int[] {1950,1961}, new int[] {1960,1971}, new int[] {1970,1981} });
        var result3 = problem.MaximumPopulation(new int[][] { new int[] {1950,2050}, new int[] {2000,2010}, new int[] {1950,2000}, new int[] {1999,2050} });

        
        // Assert
        Assert.Equal(1993, result1);
        Assert.Equal(1960, result2);
        Assert.Equal(1999, result3);
    }
}
