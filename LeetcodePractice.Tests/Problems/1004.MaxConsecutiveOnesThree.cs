using Xunit;
using Problems;

public class MaxConsecutiveOnes3Test
{
    [Fact]
    public void TestMaxConsecutiveOnes3()
    {
        // Arrange
        var problem = new MaxConsecutiveOnes3();
        
        // Act
        var result1 = problem.LongestOnes(new int[] {1,1,1,0,0,0,1,1,1,1,0}, 2);
        var result2 = problem.LongestOnes(new int[] {0,0,1,1,0,0,1,1,1,0,1,1,0,0,0,1,1,1,1}, 3);
        var result3 = problem.LongestOnes(new int[] {0,0,0,1,1,1,0,0,0,0}, 10);
        var result4 = problem.LongestOnes(new int[] {0,0,0,1}, 2);
        var result5 = problem.LongestOnes(new int[] {0,0,0,0,0,0,1,0,1,1,0}, 5);
        
        // Assert
        Assert.Equal(6, result1);
        Assert.Equal(10, result2);
        Assert.Equal(10, result3);
        Assert.Equal(3, result4);
        Assert.Equal(8, result5);
    }
}
