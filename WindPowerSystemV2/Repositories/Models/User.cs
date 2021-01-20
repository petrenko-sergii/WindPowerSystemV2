using System;

namespace WindPowerSystemV2.Repositories.Models
{
	public class User // TODO: create base-model
	{
		public virtual string Id { get; set; }
		public virtual string Email { get; set; }
		public virtual string PasswordHash { get; set; }
		public virtual string SecurityStamp { get; set; }
		public virtual string Phone { get; set; }
		public virtual DateTime RegisterDate { get; set; }
		public virtual DateTime LastLoginDate { get; set; }
		public virtual string Firstname { get; set; } 
		public virtual string LastName { get; set; }
		public virtual int WrongPassworDeffort { get; set; }
		public virtual bool Blocked { get; set; }
		public virtual bool PasswordMustBeChanged { get; set; }
		public virtual int LifeTimeForPassword { get; set; }
	}
}
