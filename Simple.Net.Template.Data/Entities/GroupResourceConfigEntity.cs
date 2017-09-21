using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("GroupResourceConfig")]
	public partial class GroupResourceConfigEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.GroupResourceConfigId;
             set => this.GroupResourceConfigId = value;
         }	

		 [Key]
		 public int GroupResourceConfigId {get;set;}

		 public int GroupId {get;set;}

		 public int ResourceCount {get;set;}

		 public int AssignResourceCount {get;set;}

		 public int Priority {get;set;}

		 public string EffectiveDate {get;set;}

		 public string IsAcitive {get;set;}

		 public int OperatorId {get;set;}

		 public string IpAddress {get;set;}

		 public DateTime UpdateTime {get;set;}

		 public DateTime CreateTime {get;set;}

	}
}
