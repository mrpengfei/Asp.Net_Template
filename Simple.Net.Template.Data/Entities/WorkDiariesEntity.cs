using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WorkDiaries")]
	public partial class WorkDiariesEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.WorkDiaryID;
             set => this.WorkDiaryID = value;
         }	

		 [Key]
		 public string WorkDiaryID {get;set;}

		 public string DiaryTypeID {get;set;}

		 public string EmployeeID {get;set;}

		 public string UserID {get;set;}

		 public string ContactInfo {get;set;}

		 public string Comment {get;set;}

		 public string CallInfoID {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

	}
}
