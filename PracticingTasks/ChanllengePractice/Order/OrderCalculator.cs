namespace PracticingTasks.ChanllengePractice.Order;

public class OrderCalculator
{
    public OrderCalResult CalculateTotal(List<OrderItem?>? orderItems,
    decimal discountPercentage,
    decimal taxPercentage)
    {
        // Step 1: Validate the complete order
        var validationResult = ValidatePricingRequest(orderItems,discountPercentage,taxPercentage);

        // Step 2: Stop if validation fails
        if (!validationResult.IsSuccess)
            return validationResult;

        //step 3 : Calculate SubTotal
        decimal subTotal = CalculateSubTotal(orderItems);

        //step 4 : Calculate discount 10%
        var discountAmount = CalculateDiscount(discountPercentage, subTotal);

        //step 5 : Calculate discounted amount
        var discountedAmount = subTotal - discountAmount;

        //step 6 : calculate tax with 18%
        var TaxAmount = CalculateTaxAmount(taxPercentage, discountedAmount);

        //step 7 : Total Amount calculated & returned
        var TotalAmount = discountedAmount + TaxAmount;
        return CreateResult(true, "Order Succesfully", TotalAmount, OrderCalculationStatus.Success,TaxAmount,discountAmount,discountedAmount,taxPercentage,discountPercentage,subTotal);
    }

    //Validation method
    private OrderCalResult ValidatePricingRequest(List<OrderItem?>? orderItems, decimal discountPercentage,
    decimal taxPercentage)
    {
        if (orderItems is null)
        {
            return CreateResult(false, "Order Can't be Null", 0,
                OrderCalculationStatus.NullOrder,0,0,0,0,0,0);
        }

        // Your implementation
        if (orderItems.Count == 0)
        {
            return CreateResult(false, "Order Can't be Empty", 0, OrderCalculationStatus.EmptyOrder, 0, 0, 0, 0, 0, 0);
        }

        if (discountPercentage < 0 || discountPercentage > 100)
        {
            return CreateResult(false, "discountPercentage can't be less than 0 & greater than 100", 0, OrderCalculationStatus.InvalidDiscountPercentage, 0, 0, 0, 0, 0, 0);
        }

        if (taxPercentage < 0 || taxPercentage > 100)
        {
            return CreateResult(false, "taxPercentage can't be less than 0 & greater than 100", 0, OrderCalculationStatus.InvalidTaxPercentage, 0, 0, 0, 0, 0, 0);
        }

        foreach (var item in orderItems)
        {
            if (item is null)
            {
                return CreateResult(false, "Item Can't be Null", 0, OrderCalculationStatus.InvalidOrderItem, 0, 0, 0, 0, 0, 0);
            }


            if (item.UnitPrice < 0)
            {
                return CreateResult(false, "UnitPrice can't Be Negative number", 0, OrderCalculationStatus.InvalidUnitPrice, 0, 0, 0, 0, 0, 0);
            }

            if (item.Quantity <= 0)
            {
                return CreateResult(false, "Quantity can't Be Less than or equal to zero", 0, OrderCalculationStatus.InvalidQuantity, 0, 0, 0, 0, 0, 0);
            }
        }
        //success
        return CreateResult(true , "Order is Valid",0,OrderCalculationStatus.Success, 0, 0, 0, 0, 0, 0);
    }

    private decimal CalculateSubTotal(List<OrderItem?>? orderItems)
    {
        decimal subTotal = 0;
        foreach (var item in orderItems!)
        {
            //calulating subTotal 
            subTotal += item!.Quantity * item.UnitPrice;
        }

        return subTotal;

    }

    private decimal CalculateDiscount(decimal discount , decimal subTotal)
    {
        decimal discountAmount = subTotal * discount / 100;
        return discountAmount;
    }
    private decimal CalculateTaxAmount(decimal tax, decimal discountAmount)
    {
        decimal TaxAmount = discountAmount * tax / 100;

        return TaxAmount;
    }

    //ReUsable method
    private OrderCalResult CreateResult(bool isSuccess , string message , decimal finalAmount , OrderCalculationStatus status , decimal taxAmount , decimal discountAmount , decimal discountedAmount , decimal taxPercentage , decimal discountPercentage , decimal subTotal)
    {
        return new OrderCalResult
        {
            IsSuccess = isSuccess,
            Message = message,
            FinalAmount = finalAmount,
            Status = status,
            TaxAmount = taxAmount,
            TaxPercentage = taxPercentage,
            DiscountAmount = discountAmount,
            DiscountedAmount = discountedAmount,
            DiscountPercentage = discountPercentage,
            SubTotal = subTotal
        };
    }
}
