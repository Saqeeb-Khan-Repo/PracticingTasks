using FluentAssertions;
using PracticingTasks.ChanllengePractice.Order;


namespace StockManagement.Test;

public class OrderCalculatorTest
{
    private readonly OrderCalculator _calculator = new();

    [Fact]
    public void CalculateTotal_WhenOrderIsNull_ReturnsZero()
    {
        // Arrange
        List<OrderItem?>? items = null;
        decimal discountPercentage = 10;
        decimal taxPercentage = 18;

        // Act
        var result = _calculator.CalculateTotal(items, discountPercentage, taxPercentage);

        // Assert
        result.FinalAmount.Should().Be(0m);
        result.IsSuccess.Should().BeFalse();
        result.Status.Should().Be(OrderCalculationStatus.NullOrder);
    }

    [Fact]
    public void CalculateTotal_EmptyOrder_ReturnZero()
    {
        // Arrange
        List<OrderItem?> items = new List<OrderItem?>();
        decimal discountPercentage = 10;
        decimal taxPercentage = 18;

        // Act
        var result = _calculator.CalculateTotal(items, discountPercentage, taxPercentage);

        // Assert
        result.FinalAmount.Should().Be(0m);
        result.IsSuccess.Should().BeFalse();
        result.Status.Should().Be(OrderCalculationStatus.EmptyOrder);
    }

    [Fact]
    public void CalculateTotal_WhenOrderContainsNullItem_ReturnsInvalidOrderItem()
    {
        // Arrange
        List<OrderItem?> items = new List<OrderItem?>()
        {
           null
        };
        decimal discountPercentage = 10;
        decimal taxPercentage = 18;

        // Act
        var result = _calculator.CalculateTotal(items, discountPercentage, taxPercentage);

        // Assert
        result.FinalAmount.Should().Be(0m);
        result.IsSuccess.Should().BeFalse();
        result.Status.Should().Be(OrderCalculationStatus.InvalidOrderItem);
    }
    [Fact]
    public void CalculateTotal_WhenUnitPriceIsNegative_ReturnsInvalidUnitPrice()
    {
        // Arrange
        List<OrderItem?> items = new List<OrderItem?>()
        {
            new OrderItem
            {
               Quantity = 2,
               UnitPrice = -10
            }
        };
        decimal discountPercentage = 10;
        decimal taxPercentage = 18;

        // Act
        var result = _calculator.CalculateTotal(items, discountPercentage, taxPercentage);

        // Assert
        result.FinalAmount.Should().Be(0m);
        result.IsSuccess.Should().BeFalse();
        result.Status.Should().Be(OrderCalculationStatus.InvalidUnitPrice);
    }
    [Fact]
    public void CalculateTotal_MixedValue_NegativeNumber_ReturnsInvalidUnitPrice()
    {
        // Arrange
        var items = new List<OrderItem?>
         {
         new() {Name = "laptop" ,Quantity = 1, UnitPrice = 50000m },
         new() {Name = "Mouse" , Quantity = 2, UnitPrice = -500m },
         new() {Name = "Keyboard" , Quantity = 1, UnitPrice = 2000m }
         };

        decimal discountPercentage = 10;
        decimal taxPercentage = 18;

        // Act
        var result = _calculator.CalculateTotal(items, discountPercentage, taxPercentage);

        // Assert
        result.FinalAmount.Should().Be(0m);
        result.IsSuccess.Should().BeFalse();
        result.Status.Should().Be(OrderCalculationStatus.InvalidUnitPrice);
    }
    [Fact]
    public void CalculateTotal_WhenQuantityIsInvalid_ReturnsInvalidQuantity()
    {
        // Arrange
        List<OrderItem?> items = new List<OrderItem?>()
        {
            new OrderItem{Quantity = -10,UnitPrice = 1000m}
        };

        decimal discountPercentage = 10;
        decimal taxPercentage = 18;

        // Act
        var result = _calculator.CalculateTotal(items, discountPercentage, taxPercentage);

        // Assert
        result.FinalAmount.Should().Be(0m);
        result.IsSuccess.Should().BeFalse();
        result.Status.Should().Be(OrderCalculationStatus.InvalidQuantity);
    }
    [Fact]
    public void CalculateTotal_WhenOrderIsValid_ReturnsCorrectTotal()
    {
        // Arrange
        List<OrderItem?> items = new()
        {
        new() { Quantity = 2, UnitPrice = 100 },
        new() { Quantity = 3, UnitPrice = 200 },
        new() { Quantity = 1, UnitPrice = 50 }
         };

        decimal discountPercentage = 10;
        decimal taxPercentage = 18;

        // Act
        var result = _calculator.CalculateTotal(items, discountPercentage, taxPercentage);

        // Assert
        result.FinalAmount.Should().Be(902.7m);
        result.IsSuccess.Should().BeTrue();
        result.Status.Should().Be(OrderCalculationStatus.Success);
    }
    [Fact]
    public void CalculateTotal_WhenProductIsFree_ReturnsSuccessfulResult()
    {
        //Arrange
        var items = new List<OrderItem?>
        {
        new() { Quantity = 2, UnitPrice = 0m }
        };

        decimal discountPercentage = 10;
        decimal taxPercentage = 18;

        // Act
        var result = _calculator.CalculateTotal(items, discountPercentage, taxPercentage);

        //Assert
        result.IsSuccess.Should().BeTrue();
        result.FinalAmount.Should().Be(0m);
        result.Status.Should().Be(OrderCalculationStatus.Success);
    }
}
