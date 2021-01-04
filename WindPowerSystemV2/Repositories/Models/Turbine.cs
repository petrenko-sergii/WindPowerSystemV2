﻿namespace WindPowerSystemV2.Repositories.Models
{
	public class Turbine
	{
		public Turbine() { }

		public virtual int Id { get; set; }
		public virtual string SerialNum { get; set; }
		public virtual int ProdMW { get; set; }

		public virtual int TurbineTypeId { get; set; }
		public virtual TurbineType TurbineType { get; set; }
	}
}
