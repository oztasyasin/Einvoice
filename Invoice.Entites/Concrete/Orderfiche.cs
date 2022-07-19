using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Invoice.Core;

namespace Invoice.Entites.Concrete
{
    public class Orderfiche:IEntity
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int ficheNo { get; set; }
        public DateTime DateTime { get; set; }
        public virtual Client Client { get; set; }
        public List<OrderLine> Lines { get; set; }
    }
}
