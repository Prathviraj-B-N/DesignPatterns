namespace Test.Patterns.Strategy
{
    class Order
    {
        private IShippingStrategy _shippingStrategy;
        public Order(IShippingStrategy shippingStrategy)
        {
            _shippingStrategy = shippingStrategy;
        }

        public void ChangeShippingStrategy(IShippingStrategy shippingStrategy)
        {
            _shippingStrategy = shippingStrategy;
        }

        public decimal GetShippingCost(OrderDetails order)
        {
            return _shippingStrategy.CalculateShippingCost(order);
        }

        public void ProcessOrder(OrderDetails order)
        {
            Console.WriteLine($"Order processed with shipping strategy: {_shippingStrategy.GetType().Name}");
            decimal shippingCost = GetShippingCost(order);
            // process the order with the calculated shipping cost
            Console.WriteLine($"Shipping Cost: {shippingCost}");
        }
    }
}