using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("BlackList")]
	public partial class BlackListEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.ID;
             set => this.ID = value;
         }	

		 [Key]
		 public string ID {get;set;}

		 public string UserID {get;set;}

		 public string EmployeeID {get;set;}

		 public string Status {get;set;}

		 public string Description {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

		 public string BlackType {get;set;}

		 public string RecordInfo {get;set;}

		 public string OpType {get;set;}

		 public string Operator {get;set;}

	}
}
