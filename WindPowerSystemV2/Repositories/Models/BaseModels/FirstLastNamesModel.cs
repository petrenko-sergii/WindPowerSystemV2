namespace WindPowerSystemV2.Repositories.Models.BaseModels
{
	public abstract class FirstLastNamesModel 
	{
		public virtual string FirstName { get; set; }
		public virtual string LastName { get; set; }
		public virtual string Email { get; set; }
		public virtual string Phone { get; set; }
	}
}
