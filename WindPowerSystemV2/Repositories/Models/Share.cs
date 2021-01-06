namespace WindPowerSystemV2.Repositories.Models
{
	public class Share
	{
		public Share() { }

		public virtual int Id { get; set; }
		public virtual string SerialNum { get; set; }
		public virtual decimal Percent { get; set; }
		public virtual decimal Price { get; set; }
	}
}
