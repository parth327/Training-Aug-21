using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Day14Api.Models;

namespace Day14Api
{
    class ToyCompanyDbContext : DbContext
    {
        public ToyCompanyDbContext() : base()
        {

        }
        public DbSet<Toy> Toys { get; set; }
        public DbSet<ToyType> ToyTypes { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<ManufacturingPlant> ManufacturingPlants { get; set; }
        public DbSet<ToyProduction> ToyProductions { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<ShipmentAddress> ShippingAddresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder      
                .UseSqlServer(@"Data Source=DESKTOP-TDGR3IJ;Initial Catalog=ToyCompanyDb;Integrated Security=True;");
        
        }
    }
}
