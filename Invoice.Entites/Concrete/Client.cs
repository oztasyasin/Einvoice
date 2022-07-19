using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Invoice.Core;

namespace Invoice.Entites.Concrete
{
    public class Client:IEntity
    {
        public int Id { get; set;}
        public string Code { get; set;}
        public string Name { get; set; }
    }
}
