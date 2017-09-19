using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("EmployeeConcactLog")]
	public partial class EmployeeConcactLogEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.EmployeeConcactLogId;
             set => this.EmployeeConcactLogId = value;
         }	

		 [Key]
		 public string EmployeeConcactLogId {get;set;}

		 public string StaffId {get;set;}

		 public string ContactTypeId {get;set;}

		 public string ContactInfo {get;set;}

		 public string Handled {get;set;}

		 public string CreateDate {get;set;}

	}
}
