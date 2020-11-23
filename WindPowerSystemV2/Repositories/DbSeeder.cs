using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WindPowerSystemV2.Repositories.Models;

namespace WindPowerSystemV2.Repositories
{
	public class DbSeeder
	{
		private static Random gen = new Random();

		public static void Seed(Context dbContext)
		{
			if (!dbContext.TurbineTypes.Any())
				CreateTurbineTypes(dbContext);
		}

		private static void CreateTurbineTypes(Context dbContext)
		{
			var typeV = new TurbineType() { Model = "V39/600", Capacity = 600 };
			var typeSG = new TurbineType() { Model = "SG 2.1-114", Capacity = 1140 };
			var typeN = new TurbineType() { Model = "N43", Capacity = 800 };
			var typeE = new TurbineType() { Model = "E-44", Capacity = 900 };

			dbContext.TurbineTypes.AddRange(typeV, typeSG, typeN, typeE);

			dbContext.SaveChanges();
		}

		private static DateTime GetRandomDate()
		{
			DateTime startDt = new DateTime(2020, 1, 1);
			int range = (DateTime.Today - startDt).Days;

			return startDt.AddDays(gen.Next(range));
		}
	}
}
