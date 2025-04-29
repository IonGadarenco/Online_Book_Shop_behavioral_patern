using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_BookStore_behavioral_design_pattern
{
    enum OrderStatus
    {
        Taken,
        Processed,
        Finished
    }
    internal class OrderBook
    {
        public string Title { get; set; }
        public OrderStatus Status { get; set; } = OrderStatus.Taken;
    }
}
