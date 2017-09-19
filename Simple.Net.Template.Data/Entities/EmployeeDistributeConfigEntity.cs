using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("EmployeeDistributeConfig")]
	public partial class EmployeeDistributeConfigEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.EmployeeDistributeConfigID;
             set => this.EmployeeDistributeConfigID = value;
         }	

		 [Key]
		 public string EmployeeDistributeConfigID {get;set;}

		 public string EmployeeID {get;set;}

		 public string ResourceSubTypeID {get;set;}

		 public string IsOpen {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

		 public string OpenTime {get;set;}

		 public string CloseTime {get;set;}

		 public string LastDistributeTime {get;set;}

		 public string CompanyDistributeTime {get;set;}

	}
}
