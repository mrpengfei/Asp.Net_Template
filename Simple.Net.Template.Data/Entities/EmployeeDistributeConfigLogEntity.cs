using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("EmployeeDistributeConfigLog")]
	public partial class EmployeeDistributeConfigLogEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.EmployeeDistributeConfigLogID;
             set => this.EmployeeDistributeConfigLogID = value;
         }	

		 [Key]
		 public string EmployeeDistributeConfigLogID {get;set;}

		 public string EmployeeID {get;set;}

		 public string ResourceSubTypeID {get;set;}

		 public string OpenTime {get;set;}

		 public string CloseTime {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

	}
}
