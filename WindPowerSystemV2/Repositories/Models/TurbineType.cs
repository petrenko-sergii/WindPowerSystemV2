namespace WindPowerSystemV2.Repositories.Models
{
	public class TurbineType
	{
		public TurbineType() { }

		public virtual int Id { get; set; }
		public virtual string Model { get; set; }
		public virtual float Capacity { get; set; }
	}
}
