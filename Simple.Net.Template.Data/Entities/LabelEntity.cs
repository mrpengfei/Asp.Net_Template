using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("Label")]
	public partial class LabelEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.LabelID;
             set => this.LabelID = value;
         }	

		 [Key]
		 public int LabelID {get;set;}

		 public string LabelName {get;set;}

		 public DateTime CreateTime {get;set;}

		 public int OperatorID {get;set;}

		 public int LabelCategoryID {get;set;}

		 public string Remark {get;set;}

		 public bool IsDeleted {get;set;}

		 public int CompanyID {get;set;}

		 public int DepartmentID {get;set;}

		 public int GroupID {get;set;}

		 public bool IsPublic {get;set;}

	}
}
