using PracticingTasks.ChanllengePractice;
using PracticingTasks.ChanllengePractice.Stock;
namespace TestProject1;

public class StockCalculatorTest
{
    [Theory] //test this method with multiple scenario
    [InlineData(1, 1, 0, StockCalculationStatus.Success)]


    public void CalculateRemainingStock_ReturnsExpectedResult(int stock , int quantity , int expectedStock, StockCalculationStatus expectedStatus)
    {
        //Arrange
        var calculator = new StockCalculator();

        //Act
        var result = calculator.CalculateRemainingStock(stock, quantity);

        //Assert
        Assert.Equal(expectedStock, result.RemainingStock);//checking stock 
        Assert.Equal(expectedStatus, result.Status);//checking status 
    }
}
