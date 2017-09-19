using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("Employee")]
	public partial class EmployeeEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.EmployeeID;
             set => this.EmployeeID = value;
         }	

		 [Key]
		 public string EmployeeID {get;set;}

		 public string Staffid {get;set;}

		 public string Password {get;set;}

		 public string TrueName {get;set;}

		 public string Gender {get;set;}

		 public string Available {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

		 public string PersonnelID {get;set;}

		 public string AttendanceID {get;set;}

		 public string OthersID {get;set;}

		 public string LastLogin {get;set;}

		 public string RecoverFlag {get;set;}

		 public string BizQQ {get;set;}

		 public string DimissionTime {get;set;}

		 public string IsManager {get;set;}

	}
}
