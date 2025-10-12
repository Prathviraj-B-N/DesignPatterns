namespace Test.Patterns.Strategy
{
    public class ExpressShippingStrategy : IShippingStrategy
    {
        private const decimal ExpressBaseRate = 150; 
        private const decimal PremiumCostPerKg = 12; 
        public decimal CalculateShippingCost(OrderDetails order)
        {
            return ExpressBaseRate + (PremiumCostPerKg * order.Weight);
        }
    }
}