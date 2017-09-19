using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("EmployeeLevel")]
	public partial class EmployeeLevelEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.EmployeeLevelId;
             set => this.EmployeeLevelId = value;
         }	

		 [Key]
		 public string EmployeeLevelId {get;set;}

		 public string EmployeeId {get;set;}

		 public string LevelConfigId {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

	}
}
