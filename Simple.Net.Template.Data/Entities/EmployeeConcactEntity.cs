using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("EmployeeConcact")]
	public partial class EmployeeConcactEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.EmployeeConcactId;
             set => this.EmployeeConcactId = value;
         }	

		 [Key]
		 public int EmployeeConcactId {get;set;}

		 public int EmployeeId {get;set;}

		 public int ContactTypeId {get;set;}

		 public string ContactInfo {get;set;}

		 public DateTime CreateDate {get;set;}

	}
}
