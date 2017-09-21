using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("EmployeeOpenFunction")]
	public partial class EmployeeOpenFunctionEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.EmployeeOpenFunctionId;
             set => this.EmployeeOpenFunctionId = value;
         }	

		 [Key]
		 public int EmployeeOpenFunctionId {get;set;}

		 public int EmployeeId {get;set;}

		 public int FunctionId {get;set;}

		 public DateTime CreateDate {get;set;}

	}
}
