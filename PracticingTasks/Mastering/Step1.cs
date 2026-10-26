

namespace PracticingTasks.Mastering;

public class Step1
{
    public static void Main()
    {
        int[] orders = { 1200, 450, -50, 1200, 0, 800, -10, 2000 };
        OrderAnalyzer analyzer = new OrderAnalyzer();
        OrderAnalysis result = analyzer.AnalyzeOrders(orders);

        Console.WriteLine("Total sum = " + result.TotalSales);
        Console.WriteLine("Valid Orders = "+  result.ValidOrderCount);
        Console.WriteLine("Orders above Average = "+ result.OrdersAboveAverage);
        Console.WriteLine("Average Order = "+result.AverageOrder);
        Console.WriteLine("Highest Order = " + result.HighestOrder);
  
    }
}

public class OrderAnalysis
{
    // properties
    public decimal TotalSales { get; set; }
    public int ValidOrderCount { get; set; }
    public decimal HighestOrder { get; set; }
    public decimal AverageOrder { get; set; }
    public int OrdersAboveAverage { get; set; }
}

public class OrderAnalyzer
{
    public OrderAnalysis AnalyzeOrders(int[] orders)
    {
        OrderAnalysis result = new OrderAnalysis();
        int count = 0;
        decimal highest = 0;
        decimal sum = 0;
        int aboveAverage = 0;

        // 1. validate empty input
        if(orders.Length == 0)
        {
            Console.WriteLine("No orders Available");
            return result; //stop here 
        }
        // 2. calculate:
        //    sum
        //    valid count
        //    highest
        foreach (var item in orders)
        {
            if (item > 0)
            {
                sum += item;
                count++;

                if (item > highest)
                {
                    highest = item;
                }
            }
        }
            // 3. handle zero valid orders
            if(count == 0)
            {
                Console.WriteLine("No valid Orders");
                return result;
            }

            // 4. calculate average
            decimal average = sum / count;

        // 5. count above average
        foreach (var item in orders)
        {
           
            if (item > 0 && item > average)
            {
                aboveAverage++;
            }

        }
        // 6. create OrderAnalysis
        //assign value in property
        result.TotalSales = sum;
        result.ValidOrderCount = count;
        result.HighestOrder = highest;
        result.OrdersAboveAverage = aboveAverage;
        result.AverageOrder = average;


        // 7. return result
        return result;

    }
}