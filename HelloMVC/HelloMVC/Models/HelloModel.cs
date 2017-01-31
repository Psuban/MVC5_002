using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloMVC.Models
{
    public class HelloModel
    {
        public static List<Stagees> GetStagees()
        {
            List<Stagees> stagees = new List<Stagees>
            {
                new Stagees {Id = 1,Name = "Saz",GroupFlight="Yes",PaymentStatus ="N/A" },
                new Stagees {Id = 2,Name="Sub",GroupFlight="Yes",PaymentStatus ="Paid" },
                new Stagees {Id = 3,Name="Vicks",GroupFlight="Yes",PaymentStatus ="Paid"},
                new Stagees {Id = 4,Name="Fus",GroupFlight="Outbound Only",PaymentStatus ="N/A"},
                new Stagees {Id = 5,Name="Rogs",GroupFlight="Yes",PaymentStatus ="Paid"},
                new Stagees {Id = 6,Name="James",GroupFlight="Outbound Only",PaymentStatus ="Paid"},
                new Stagees {Id = 7,Name="Ketan",GroupFlight="Yes",PaymentStatus ="Paid"},
                new Stagees {Id = 8,Name="Pritesh",GroupFlight="Yes",PaymentStatus ="Paid"},
                new Stagees {Id = 9,Name="Kiran",GroupFlight="Yes",PaymentStatus ="Paid"},
                new Stagees {Id = 10,Name="Vishal",GroupFlight="Yes",PaymentStatus ="Paid"},
                new Stagees {Id = 11,Name="Gops",GroupFlight="Yes",PaymentStatus ="Not Paid"},
                new Stagees {Id = 12,Name="Rags",GroupFlight="Independent",PaymentStatus ="N/A"},
                new Stagees {Id = 13,Name="Bavan",GroupFlight="Yes",PaymentStatus ="N/A"},
                new Stagees {Id = 14,Name="Jana",GroupFlight="Independent",PaymentStatus ="N/A"},
                new Stagees {Id = 15,Name="Mayu",GroupFlight="Independent",PaymentStatus ="N/A"},
                new Stagees {Id = 16,Name="Raz",GroupFlight="Independent",PaymentStatus ="N/A"},
            };
            return stagees;
        }
    }

    public class Stagees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string GroupFlight { get; set; }
        public string PaymentStatus { get; set; }
    }
}