using System;
using WindPowerSystemV2.Repositories.Models.BaseModels;

namespace WindPowerSystemV2.Repositories.Models
{
	public class User : FirstLastNamesModel
	{
		public virtual string Id { get; protected set; }
		public virtual string PasswordHash { get; set; }
		public virtual string SecurityStamp { get; set; }
		public virtual DateTime RegisterDate { get; set; }
		public virtual DateTime LastLoginDate { get; set; }
		public virtual int WrongPassworDeffort { get; set; }
		public virtual bool Blocked { get; set; }
		public virtual bool PasswordMustBeChanged { get; set; }
		public virtual int LifeTimeForPassword { get; set; }
	}
}
