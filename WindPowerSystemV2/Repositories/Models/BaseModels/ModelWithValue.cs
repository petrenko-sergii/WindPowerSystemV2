namespace WindPowerSystemV2.Repositories.Models.BaseModels
{
	public abstract class ModelWithValue
	{
		public virtual int Id { get; set; }
		public virtual string Value { get; set; }
	}
}
