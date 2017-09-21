using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("EmployeeLevel")]
	public partial class EmployeeLevelEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.EmployeeLevelId;
             set => this.EmployeeLevelId = value;
         }	

		 [Key]
		 public int EmployeeLevelId {get;set;}

		 public int EmployeeId {get;set;}

		 public int LevelConfigId {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

	}
}
