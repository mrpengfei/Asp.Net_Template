using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("EmployeeDistributeConfig")]
	public partial class EmployeeDistributeConfigEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.EmployeeDistributeConfigID;
             set => this.EmployeeDistributeConfigID = value;
         }	

		 [Key]
		 public int EmployeeDistributeConfigID {get;set;}

		 public int EmployeeID {get;set;}

		 public int ResourceSubTypeID {get;set;}

		 public bool IsOpen {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

		 public DateTime OpenTime {get;set;}

		 public DateTime CloseTime {get;set;}

		 public DateTime LastDistributeTime {get;set;}

		 public DateTime CompanyDistributeTime {get;set;}

	}
}
