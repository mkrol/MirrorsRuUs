using System;
using System.Collections.Generic;
using System.Linq;
using MRU.Web.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MRU.Data
{
    public class MRUContext : DbContext 
    {
        public MRUContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<ProductModel> Products { get; set; }
        public DbSet<CategoryModel> Categories { get; set; }
    }
}
