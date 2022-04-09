using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeeDine.Backend.Models
{
    public class BillItem
    {
        public int Id { get; set; }
        public OrderItem TableItem { get; set; }
        public List<User> Payer { get; set; }

        public BillItem(OrderItem item, User name)
        {
            Random random = new Random();
            Id = random.Next();
            TableItem = item;
            Payer = new List<User>();
            Payer.Add(name);
        }
    }
}
