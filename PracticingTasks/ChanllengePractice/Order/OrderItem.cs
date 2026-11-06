namespace PracticingTasks.ChanllengePractice.Order;

public class OrderItem
{
    public Guid ProductId { get; set; }

    public string Name { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
}
