// using Test.Patterns.Strategy;

// Test.Patterns.Strategy.Order order = new Test.Patterns.Strategy.Order(new ExpressShipping());

// OrderDetails od = new OrderDetails { OrderAmount = 1000, Weight = 5, Distance = 100, IsFragile = false };
// order.ProcessOrder(od);

// order.ChangeShippingStrategy(new LocalPickup());
// order.ProcessOrder(od);

// order.ChangeShippingStrategy(new StandardShipping());
// order.ProcessOrder(od);

// Output:
// Order processed with shipping strategy: ExpressShipping
// Shipping Cost: 210
// Order processed with shipping strategy: LocalPickup
// Shipping Cost: 20
// Order processed with shipping strategy: StandardShipping
// Shipping Cost: 75