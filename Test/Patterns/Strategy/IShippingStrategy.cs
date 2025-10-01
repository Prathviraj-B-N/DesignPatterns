namespace Test.Patterns.Strategy
{
    public interface IShippingStrategy
    {
        decimal CalculateShippingCost(OrderDetails order);
    }
}