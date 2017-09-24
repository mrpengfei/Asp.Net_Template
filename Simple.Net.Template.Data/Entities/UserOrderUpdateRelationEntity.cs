using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserOrderUpdateRelation")]
	public partial class UserOrderUpdateRelationEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.UserOrderUpdateRelationId;
             set => this.UserOrderUpdateRelationId = value;
         }	

		 [Key]
		 public int UserOrderUpdateRelationId {get;set;}

		 public string OldUserOrderNo {get;set;}

		 public string NewUserOrderNo {get;set;}

		 public decimal OldOrderSurplusValue {get;set;}

		 public DateTime CreateDateTime {get;set;}

	}
}
