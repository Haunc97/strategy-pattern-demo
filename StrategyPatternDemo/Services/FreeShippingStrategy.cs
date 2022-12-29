namespace StrategyPatternDemo.Services;

public class FreeShippingStrategy : IShippingStrategy
{
    public decimal CalculateFinalTotal(decimal orderTotal)
    {
        return orderTotal;
    }
}