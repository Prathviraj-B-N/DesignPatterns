
using Test.Patterns.Strategy;

Test.Patterns.Strategy.Order order = new Test.Patterns.Strategy.Order(new ExpressShippingStrategy());

OrderDetails od = new OrderDetails { OrderAmount = 1000, Weight = 5, Distance = 100, IsFragile = false };
order.ProcessOrder(od);

order.ChangeShippingStrategy(new LocalPickupStrategy());
order.ProcessOrder(od);

order.ChangeShippingStrategy(new StandardShippingStrategy());
order.ProcessOrder(od);