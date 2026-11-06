namespace PracticingTasks.ChanllengePractice.Stock;


public class StockCalculator
{
    public StockCalculationResult CalculateRemainingStock(int stock, int quantity)
    {
        if (stock < 0)
            return new StockCalculationResult
            {
  
                RemainingStock = stock,
                Status = StockCalculationStatus.InvalidInventory
            };

        if (quantity <= 0)
        {
            return new StockCalculationResult
            {
              
                RemainingStock = stock,
                Status = StockCalculationStatus.InvalidQuantity
            };
        }
          

        if (quantity > stock)
        {
            return new StockCalculationResult
            {
             
                RemainingStock = stock,
                Status = StockCalculationStatus.InsufficientStock
            };
        }

       var updated = stock - quantity;

         return new StockCalculationResult
        {
    
            RemainingStock = updated,
            Status = StockCalculationStatus.Success
        };
    }
}