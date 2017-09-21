using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("EmployeeDistributeConfigLog")]
	public partial class EmployeeDistributeConfigLogEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.EmployeeDistributeConfigLogID;
             set => this.EmployeeDistributeConfigLogID = value;
         }	

		 [Key]
		 public int EmployeeDistributeConfigLogID {get;set;}

		 public int EmployeeID {get;set;}

		 public int ResourceSubTypeID {get;set;}

		 public DateTime OpenTime {get;set;}

		 public DateTime CloseTime {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

	}
}
