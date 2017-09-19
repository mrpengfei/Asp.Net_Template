using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserRisk")]
	public partial class UserRiskEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.UserID;
             set => this.UserID = value;
         }	

		 [Key]
		 public string UserID {get;set;}

 		 public override int Key
         {
             get => this.RiskTypeId;
             set => this.RiskTypeId = value;
         }	

		 [Key]
		 public string RiskTypeId {get;set;}

	}
}
