namespace StrategyPatternDemo.Services;

public interface IShippingContext
{
    void SetStrategy(IShippingStrategy strategy);

    decimal ExecuteStrategy(decimal orderTotal);
}