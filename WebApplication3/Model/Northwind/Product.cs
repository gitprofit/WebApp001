using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Web;

namespace WebApplication3.Model.Northwind
{
	public class Product
	{
		public int ProductID { get; set; }
		public string ProductName { get; set; }
		//[
		[ForeignKey("CategoryID")]
		public string QuantityPerUnit { get; set; }

		public Supplier Supplier { get; set; }
		//[System.ComponentModel.DataAnnotations.Association("Category", "CategoryID", "CategoryID")]
		public Category Category { get; set; }
	}

	class ProductMapping : EntityTypeConfiguration<Product>
	{
		public ProductMapping()
			: base()
		{
			
			this.HasKey(t => t.ProductID).Property(t => t.ProductID).HasColumnName("ProductID");

			this.Property(t => t.ProductName).HasMaxLength(40).HasColumnName("ProductName");
			this.Property(t => t.QuantityPerUnit).HasColumnName("QuantityPerUnit");

			this.HasOptional(t => t.Supplier).WithMany().Map(t => t.MapKey("SupplierID"));
			this.HasOptional(t => t.Category).WithMany().Map(t => t.MapKey("CategoryID"));

			this.ToTable("products");
		}
	}
}


/*
	EF TUT: http://www.entityframeworktutorial.net/EntityFramework4.3/Introduction.aspx
*/