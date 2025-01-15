using Xunit;
using Problems;

public class KadanesAlgorithmTest
{
    [Fact]
    public void KadanesAlgorithm()
    {
        var problem = new KadanesAlgorithm();

        var result1 = problem.FindMaxSumSubArray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });
        var result2 = problem.FindMaxSumSubArray(new int[] { 4, -1, 2, -7, 3, 4 });
        // good example of why we start over if currentSum is negative
        var result3 = problem.FindMaxSumSubArray(new int[] { 2, -4, 8, 4, -3, 1 }); 

        Assert.Equal(6, result1);
        Assert.Equal(7, result2);
        Assert.Equal(12, result3);
    }
}