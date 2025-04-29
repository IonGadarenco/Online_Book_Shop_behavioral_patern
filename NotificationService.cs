using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_BookStore_behavioral_design_pattern
{
    internal class NotificationService
    {
        private List<ISubscriber> _observators = new List<ISubscriber>();

        public void Subscribe(ISubscriber observator) 
        {
            _observators.Add(observator);
        }

        public void Unsubscribe(ISubscriber observator)
        {
            _observators.Remove(observator);
        }

        public void SendNotification(string notification)
        {
            foreach (var observator in _observators)
            {
                observator.ReceiveNotification(notification);
            }
        }
    }
}
