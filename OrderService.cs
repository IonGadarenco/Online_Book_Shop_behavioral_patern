using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_BookStore_behavioral_design_pattern
{
    internal class OrderService
    {
        private NotificationService _userNotificationService;
        private NotificationService _staffNotificationService;
        public OrderService(NotificationService userNotificationService, NotificationService staffNotificationService) 
        {
            _userNotificationService = userNotificationService;
            _staffNotificationService = staffNotificationService;
        }
        public void OrderBookOnline(User user, OrderBook book)
        {
            Console.WriteLine("====For Staff====");
            _staffNotificationService.SendNotification($" {user.Name} has ordered the book: {book.Title}");
        }

        public void ProcessingOrder(OrderBook book) 
        {
            Console.WriteLine("====For Users====");

            if (book.Status == OrderStatus.Taken)
            {
                Thread.Sleep(1000);
                book.Status = OrderStatus.Processed;
                _userNotificationService.SendNotification($"Order for '{book.Title}' has been processed.");
            }

            Console.WriteLine("====For Staff====");

            Thread.Sleep(1000);
            book.Status = OrderStatus.Finished;
            _userNotificationService.SendNotification($"Order for '{book.Title}' is finished and ready for shipping.");
        }
    }
}
