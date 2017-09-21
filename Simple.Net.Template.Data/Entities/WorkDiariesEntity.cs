using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WorkDiaries")]
	public partial class WorkDiariesEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.WorkDiaryID;
             set => this.WorkDiaryID = value;
         }	

		 [Key]
		 public int WorkDiaryID {get;set;}

		 public int DiaryTypeID {get;set;}

		 public int EmployeeID {get;set;}

		 public string UserID {get;set;}

		 public string ContactInfo {get;set;}

		 public string Comment {get;set;}

		 public int CallInfoID {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

	}
}
