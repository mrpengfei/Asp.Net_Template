using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("EmployeeConcact")]
	public partial class EmployeeConcactEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.EmployeeConcactId;
             set => this.EmployeeConcactId = value;
         }	

		 [Key]
		 public string EmployeeConcactId {get;set;}

		 public string EmployeeId {get;set;}

		 public string ContactTypeId {get;set;}

		 public string ContactInfo {get;set;}

		 public string CreateDate {get;set;}

	}
}
