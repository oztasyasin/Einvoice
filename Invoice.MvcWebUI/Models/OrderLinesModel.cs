using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Invoice.Entites.Concrete;

namespace Invoice.MvcWebUI.Models
{
    public class OrderLinesModel
    {
        public List<OrderLine> orderLines { get; set; }
        public List<Item> items { get; set; }
    }
}
