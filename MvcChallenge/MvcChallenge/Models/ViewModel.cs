using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcChallenge.Models
{
    public class ViewModel
    {
        public List<Order> Orders { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Product> Products { get; set; }
    }
}