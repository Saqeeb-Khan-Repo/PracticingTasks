

namespace PracticingTasks.ChanllengePractice.Order;

public record OrderCalResult
{
    public bool IsSuccess { get; set; }
    public string Message { get; set; } = string.Empty;
 
    public OrderCalculationStatus Status { get; set; }

    public decimal SubTotal { get; set; }
    public decimal DiscountPercentage { get; set; }
    public decimal DiscountAmount { get; set; }
    public decimal DiscountedAmount { get; set; }
    public decimal TaxPercentage { get; set; }
    public decimal TaxAmount { get; set; }
    public decimal FinalAmount { get; set; }
};

