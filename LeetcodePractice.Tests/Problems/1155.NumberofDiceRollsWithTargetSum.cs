using Xunit;
using Problems;

public class NumberOfDiceRollsWithTargetSumTest
{
    [Fact]
    public void TestNumberOfDiceRollsWithTargetSum()
    {
        // Arrange
        var problem = new TestNumberOfDiceRollsWithTargetSum1155();
        
        // Act
        var result1 = problem.NumRollsToTarget(1,6,3);
        var result2 = problem.NumRollsToTarget(2,6,7);
        var result3 = problem.NumRollsToTarget(30,30,500);

        
        // Assert
        Assert.Equal(1, result1);
        Assert.Equal(6, result2);
        Assert.Equal(222616187, result3);
    }
}
