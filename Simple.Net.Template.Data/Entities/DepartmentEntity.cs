using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("Department")]
	public partial class DepartmentEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.DepartmentID;
             set => this.DepartmentID = value;
         }	

		 [Key]
		 public string DepartmentID {get;set;}

		 public string DepartmentName {get;set;}

		 public string companyid {get;set;}

	}
}
