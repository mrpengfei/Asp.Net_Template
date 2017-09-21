using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("Employee")]
	public partial class EmployeeEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.EmployeeID;
             set => this.EmployeeID = value;
         }	

		 [Key]
		 public int EmployeeID {get;set;}

		 public string Staffid {get;set;}

		 public string Password {get;set;}

		 public string TrueName {get;set;}

		 public int Gender {get;set;}

		 public string Available {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

		 public string PersonnelID {get;set;}

		 public string AttendanceID {get;set;}

		 public string OthersID {get;set;}

		 public DateTime LastLogin {get;set;}

		 public int RecoverFlag {get;set;}

		 public string BizQQ {get;set;}

		 public DateTime DimissionTime {get;set;}

		 public string IsManager {get;set;}

	}
}
