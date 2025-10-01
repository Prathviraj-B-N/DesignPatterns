class Order
{
    private readonly INotificationService _notificationService;

    public Order(INotificationService notificationService)
    {
        this._notificationService = notificationService;
    }
    public void Process()
    {
        System.Console.WriteLine("processed Order Succesfully");
        Notify();
    }
    public void Notify()
    {
        // EmailSender emailSender = new EmailSender();
        // emailSender.SendEmail("Your order has been processed.");

        // SMSSender smsSender = new SMSSender();
        // smsSender.SendSMS("Your order has been processed.");

        _notificationService.SendNotofication("Your order has been processed.");

    }
}