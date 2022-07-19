using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Invoice.Core;

namespace Invoice.Entites.Concrete
{
    public class OrderLine:IEntity
    {
        public int Id { get; set; }
        public int OrderFicheId { get; set; }
        public int ItemId { get; set; }
        public virtual Item Item { get; set; }
        public int Amout { get; set; }
        public double Price { get; set; }
        public double Total { get; set; }
    }
}
