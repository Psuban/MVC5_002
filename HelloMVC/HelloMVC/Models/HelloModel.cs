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
                new Stagees {Id = 1,Name = "Saz" },
                new Stagees {Id = 2,Name="Sub"},
                new Stagees {Id = 3,Name="Vicks"},
                new Stagees {Id = 4,Name="Fus"},
                new Stagees {Id = 5,Name="Rogs"},
                new Stagees {Id = 6,Name="James"},
                new Stagees {Id = 7,Name="Ketan"},
                new Stagees {Id = 8,Name="Pritesh"},
                new Stagees {Id = 9,Name="Kiran"},
                new Stagees {Id = 10,Name="Vishal"},
                new Stagees {Id = 11,Name="Gops"},
                new Stagees {Id = 12,Name="Rags"},
                new Stagees {Id = 13,Name="Bavan"},
                new Stagees {Id = 14,Name="Jana"},
                new Stagees {Id = 15,Name="Mayu"},
                new Stagees {Id = 16,Name="Raz"},
            };
            return stagees;
        }
    }

    public class Stagees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
    }
}