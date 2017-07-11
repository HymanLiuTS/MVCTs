using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    public class ShoppingCarViewModel
    {
        public List<Product> Products { get; set; }
        public String Message { get; set; }
        public double TotalCost { get; set; }
    }
}