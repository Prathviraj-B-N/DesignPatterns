namespace Test.Patterns.Strategy
{
    public class LocalPickupStrategy : IShippingStrategy
    {
        private const decimal HandlingCharges = 20; 
        
        public decimal CalculateShippingCost(OrderDetails order)
        {
            return HandlingCharges;
        }
    }
}