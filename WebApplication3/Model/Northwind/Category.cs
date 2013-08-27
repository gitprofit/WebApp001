using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace WebApplication3.Model.Northwind
{
	public class Category
	{
		public int CategoryID { get; set; }
		public string CategoryName { get; set; }
		public string Description { get; set; }
		//public string Picture { get; set; }

		//public ICollection<Product> Products { get; set; }
	}

	class CategoryMapping : EntityTypeConfiguration<Category>
	{
		public CategoryMapping()
			: base()
		{
			this.HasKey(t => t.CategoryID).Property(t => t.CategoryID).HasColumnName("CategoryID");

			this.Property(t => t.CategoryName).HasColumnName("CategoryName");
			this.Property(t => t.Description).HasColumnName("Description");
			//this.Property(t => t.Picture).HasColumnName("Picture");

			//this.HasMany(t => t.Products).WithRequired().HasForeignKey(t => t.Category);

			this.ToTable("categories");
		}
	}
}