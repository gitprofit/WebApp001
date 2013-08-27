using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace WebApplication3.Model.Northwind
{
	public class Supplier
	{
		public int SupplierID { get; set; }
		public string CompanyName { get; set; }
		public string ContactName { get; set; }
		public string ContactTitle { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string Region { get; set; }
		public string PostalCode { get; set; }
		public string Country { get; set; }
		public string Phone { get; set; }

		//public ICollection<Product> Products { get; set; }
	}

	class SupplierMapping : EntityTypeConfiguration<Supplier>
	{
		public SupplierMapping()
			: base()
		{
			this.HasKey(t => t.SupplierID).Property(t => t.SupplierID).HasColumnName("SupplierID");

			this.Property(t => t.CompanyName).HasColumnName("CompanyName");
			this.Property(t => t.ContactName).HasColumnName("ContactName");
			this.Property(t => t.ContactTitle).HasColumnName("ContactTitle");
			this.Property(t => t.Address).HasColumnName("Address");
			this.Property(t => t.City).HasColumnName("City");
			this.Property(t => t.Region).HasColumnName("Region");
			this.Property(t => t.PostalCode).HasColumnName("PostalCode");
			this.Property(t => t.Country).HasColumnName("Country");
			this.Property(t => t.Phone).HasColumnName("Phone");

			//this.HasMany<Product>(t => t.Products).WithOptional().HasForeignKey(t => t.Supplier);

			this.ToTable("suppliers");
		}
	}

}