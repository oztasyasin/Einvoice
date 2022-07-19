using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Invoice.Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Invoice.DataAccess.Concrete.EntityFramework
{
    public class EIContext:DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Orderfiche> Orderfiches { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-NKVHEEHT;Initial Catalog=new2;Integrated Security=True");
        }
    }
}
