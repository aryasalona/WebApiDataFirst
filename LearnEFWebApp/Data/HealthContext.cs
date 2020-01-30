using LearnEFWebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnEFWebApp.Data
{
	public class HealthContext : DbContext
	{
		
		public HealthContext(DbContextOptions options)
		: base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
		}

		public DbSet<Patient>  Patients { get; set; }
		public DbSet<Ailment> Ailments { get; set; }
		public DbSet<Medication> Medications { get; set; }
	

	}
}
