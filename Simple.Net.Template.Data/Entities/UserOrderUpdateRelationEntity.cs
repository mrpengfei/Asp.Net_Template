using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserOrderUpdateRelation")]
	public partial class UserOrderUpdateRelationEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.UserOrderUpdateRelationId;
             set => this.UserOrderUpdateRelationId = value;
         }	

		 [Key]
		 public string UserOrderUpdateRelationId {get;set;}

 		 public override string Key
         {
             get => this.OldUserOrderNo;
             set => this.OldUserOrderNo = value;
         }	

		 [Key]
		 public string OldUserOrderNo {get;set;}

 		 public override string Key
         {
             get => this.NewUserOrderNo;
             set => this.NewUserOrderNo = value;
         }	

		 [Key]
		 public string NewUserOrderNo {get;set;}

		 public string OldOrderSurplusValue {get;set;}

		 public string CreateDateTime {get;set;}

	}
}
