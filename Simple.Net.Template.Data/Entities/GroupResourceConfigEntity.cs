using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("GroupResourceConfig")]
	public partial class GroupResourceConfigEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.GroupResourceConfigId;
             set => this.GroupResourceConfigId = value;
         }	

		 [Key]
		 public string GroupResourceConfigId {get;set;}

		 public string GroupId {get;set;}

		 public string ResourceCount {get;set;}

		 public string AssignResourceCount {get;set;}

		 public string Priority {get;set;}

		 public string EffectiveDate {get;set;}

		 public string IsAcitive {get;set;}

		 public string OperatorId {get;set;}

		 public string IpAddress {get;set;}

		 public string UpdateTime {get;set;}

		 public string CreateTime {get;set;}

	}
}
