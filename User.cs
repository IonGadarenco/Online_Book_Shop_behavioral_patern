using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_BookStore_behavioral_design_pattern
{
    internal class User : ISubscriber
    {
        public string Name {  get; set; }
        public string Email { get; set; }
        public void ReceiveNotification(string notification)
        {
            Console.WriteLine($"Emeil to {Name} => {notification}");
        }

       
    }
}
