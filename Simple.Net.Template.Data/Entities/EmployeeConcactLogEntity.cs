using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("EmployeeConcactLog")]
	public partial class EmployeeConcactLogEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.EmployeeConcactLogId;
             set => this.EmployeeConcactLogId = value;
         }	

		 [Key]
		 public int EmployeeConcactLogId {get;set;}

		 public string StaffId {get;set;}

		 public int ContactTypeId {get;set;}

		 public string ContactInfo {get;set;}

		 public bool Handled {get;set;}

		 public DateTime CreateDate {get;set;}

	}
}
