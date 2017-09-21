using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("BlackList")]
	public partial class BlackListEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.ID;
             set => this.ID = value;
         }	

		 [Key]
		 public int ID {get;set;}

		 public string UserID {get;set;}

		 public int EmployeeID {get;set;}

		 public int Status {get;set;}

		 public string Description {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

		 public int BlackType {get;set;}

		 public string RecordInfo {get;set;}

		 public int OpType {get;set;}

		 public int Operator {get;set;}

	}
}
