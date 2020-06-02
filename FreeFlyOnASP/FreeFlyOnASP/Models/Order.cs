using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FreeFlyOnASP.Models
{
    public class Order
    {
        public int Id { get; set; }
        public List<Book> Books   { get; set; }     
        public double TotalPrice { get; set; }
        public DateTime Date { get; set; }

    }
}