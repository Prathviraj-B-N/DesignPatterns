namespace Test.Patterns.Strategy
{
    class StandardShippingStrategy : IShippingStrategy
    {
        private const decimal FlatRate = 50; 
        private const decimal CostPerKg = 5; 

        public decimal CalculateShippingCost(OrderDetails order)
        {
            if(order.Weight < 0) throw new ArgumentException("Weight cannot be negative");
            return FlatRate + (CostPerKg * order.Weight);
        }
    }
}