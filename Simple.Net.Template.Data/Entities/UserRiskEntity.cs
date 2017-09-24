using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserRisk")]
	public partial class UserRiskEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.UserID;
             set => this.UserID = value;
         }	

		 [Key]
		 public string UserID {get;set;}

		 public int RiskTypeId {get;set;}

	}
}
