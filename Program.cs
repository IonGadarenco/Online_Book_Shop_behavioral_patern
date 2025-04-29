using Online_BookStore_behavioral_design_pattern;

internal class Program
{
    private static void Main(string[] args)
    {
        var books = new List<OrderBook>
        {
            new OrderBook{ Title = "Biserica verticala"},
            new OrderBook{ Title = "Handicapul Constiintei"},
            new OrderBook{ Title = "Biblia"},
            new OrderBook{ Title = "Cele 5 limbaje ale iubirii"},
            new OrderBook{ Title = "Marturii care cer un verdict"}
        };

        var userNotificationService = new NotificationService();
        var staffNotificationService = new NotificationService();
        var orderService = new OrderService(userNotificationService, staffNotificationService);

        var user1 = new User { Name = "Ion", Email = "ion@gmail.com" };
        var user2 = new User { Name = "Dana", Email = "dana@gmail.com" };

        var staff1 = new Staff { Name = "Mihai", Email = "mihai@gmail.com" };
        var staff2 = new Staff { Name = "Andrei", Email = "andrei@gmail.com" };

        userNotificationService.Subscribe(user1);
        userNotificationService.Subscribe(user2);

        staffNotificationService.Subscribe(staff1);
        staffNotificationService.Subscribe(staff2);

        orderService.OrderBookOnline(user1, books[0]);
        orderService.ProcessingOrder(books[0]);

    }
}