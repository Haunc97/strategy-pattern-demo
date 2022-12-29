namespace StrategyPatternDemo.Services;

public class LocalShippingStrategy : IShippingStrategy
{
    public decimal CalculateFinalTotal(decimal orderTotal)
    {
        return orderTotal + 10;
    }
}
