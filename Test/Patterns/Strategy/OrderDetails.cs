namespace Test.Patterns.Strategy
{
    public class OrderDetails
    {
        Guid OrderId { get; set; }
        public decimal OrderAmount { get; set; }
        public decimal Weight { get; set; }
        public decimal Distance { get; set; }
        public bool IsFragile { get; set; }
    }
}