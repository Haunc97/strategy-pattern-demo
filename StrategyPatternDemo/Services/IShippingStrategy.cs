namespace StrategyPatternDemo.Services;

public interface IShippingStrategy
{
    decimal CalculateFinalTotal(decimal orderTotal);
}