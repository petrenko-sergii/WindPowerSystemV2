namespace WindPowerSystemV2.Repositories.Models.BaseModels
{
	public abstract class ModelWithName
	{
		public virtual int Id { get; set; }
		public virtual string Name { get; set; }
	}
}
