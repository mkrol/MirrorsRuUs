using System;
using System.Collections.Generic;
using System.Linq;
using MRU.Web.Models;
using MRU.Web.Models.Category;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MRU.Data
{
    public class MRUContext : DbContext 
    {
        public MRUContext()
            : base("DefaultConnection")
        {
            Database.SetInitializer<MRUContext>(null);
        }

        public DbSet<ProductModel> Products { get; set; }
        public DbSet<CategoryModel> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            
        }
    }
}
