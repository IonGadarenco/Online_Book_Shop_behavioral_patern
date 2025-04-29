using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_BookStore_behavioral_design_pattern
{
    internal interface ISubscriber
    {
        public void ReceiveNotification(string notification);
    }
}
