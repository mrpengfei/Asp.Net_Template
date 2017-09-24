using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("EmployeeResourceConfig")]
	public partial class EmployeeResourceConfigEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.EmployeeResourceConfigId;
             set => this.EmployeeResourceConfigId = value;
         }	

		 [Key]
		 public int EmployeeResourceConfigId {get;set;}

		 public int DepartmentId {get;set;}

		 public int GroupId {get;set;}

		 public int EmployeeId {get;set;}

		 public int ResourceCount {get;set;}

		 public int AssignResourceCount {get;set;}

		 public int Priority {get;set;}

		 public string EffectiveDate {get;set;}

		 public bool IsAcitive {get;set;}

		 public int OperatorId {get;set;}

		 public string IpAddress {get;set;}

		 public DateTime UpdateTime {get;set;}

		 public DateTime CreateTime {get;set;}

	}
}
