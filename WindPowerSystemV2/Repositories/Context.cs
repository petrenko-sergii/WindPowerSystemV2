using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WindPowerSystemV2.Repositories.Models;

namespace WindPowerSystemV2.Repositories
{
	public class Context : DbContext
	{
		public Context(DbContextOptions options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder) {
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<TurbineType>().ToTable("TurbineType");
			modelBuilder.Entity<TurbineType>().Property(i => i.Id).ValueGeneratedOnAdd();
		}

		public DbSet<TurbineType> TurbineTypes { get; set; }
	}
}
