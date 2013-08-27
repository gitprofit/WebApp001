using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication3.Model
{
	public class Term
	{
		public int TermId { get; set; }
		public int Start { get; set; }
		public int End { get; set; }
	}

	public class Course
	{
		public int CourseId { get; set; }
		public virtual ICollection<Term> Terms { get; set; }
	}

	public class ModelContext : DbContext
	{
		ModelContext(string connStr)
			: base(connStr)
		{
			// http://beniaminzaborski.wordpress.com/tag/entity-framework-code-first/
		}
	}
}