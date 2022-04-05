using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeeDine.Backend.Models
{
    public class Table
    {
        public List<User> GuestList { get; set; }

        public Table(List<User> userList)
        {
            GuestList = userList;
        }
        
    }
}
