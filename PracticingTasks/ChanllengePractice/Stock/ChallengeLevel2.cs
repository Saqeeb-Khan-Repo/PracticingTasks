namespace PracticingTasks.ChanllengePractice.Stock;

public class ChallengeLevel2
{
    static int CalculateRemainingStock(int stock, int quantity)
    {
        // Validation 1: Is stock valid?
        if(stock < 0)
        {
            return stock;
        }

        // Validation 2: Is quantity valid?
        if (quantity <= 0)
        {
            return stock;
        }

        // Validation 3: Is sufficient stock available?
        if (quantity > stock)
        {
            return stock;
        }

        // Calculation: Return remaining stock
        stock -= quantity;

        return stock;
    }

    static void Main()
    {
        int stock = 10;

        // Call your method and receive the returned value.
        var result = CalculateRemainingStock(stock, 3);

        // Print the result.
        Console.WriteLine(result);
    }
}
