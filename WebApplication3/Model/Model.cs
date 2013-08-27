using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

// http://beniaminzaborski.wordpress.com/tag/entity-framework-code-first/

namespace WebApplication3.Model
{
	namespace Northwind
	{

		public class NorthwindContext : DbContext
		{
			public DbSet<Supplier> Suppliers { get; set; }
			public DbSet<Product> Products { get; set; }
			public DbSet<Category> Categories { get; set; }

			public NorthwindContext(string connStr)
				: base(connStr)
			{ }

			protected override void OnModelCreating(DbModelBuilder modelBuilder)
			{
				base.OnModelCreating(modelBuilder);

				modelBuilder.Configurations.Add(new SupplierMapping());
				modelBuilder.Configurations.Add(new ProductMapping());
				modelBuilder.Configurations.Add(new CategoryMapping());
			}
		}
	}
}