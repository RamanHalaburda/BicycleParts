using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BicycleParts.Models
{
    public class PartContext : DbContext
    {
        public PartContext() : base("BicycleParts")
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Parts> Parts { get; set; }
    }
}