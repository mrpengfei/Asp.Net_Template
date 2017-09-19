using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("EmployeeOpenFunction")]
	public partial class EmployeeOpenFunctionEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.EmployeeOpenFunctionId;
             set => this.EmployeeOpenFunctionId = value;
         }	

		 [Key]
		 public string EmployeeOpenFunctionId {get;set;}

		 public string EmployeeId {get;set;}

		 public string FunctionId {get;set;}

		 public string CreateDate {get;set;}

	}
}
