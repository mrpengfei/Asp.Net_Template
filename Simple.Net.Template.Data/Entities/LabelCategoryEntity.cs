using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("LabelCategory")]
	public partial class LabelCategoryEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.LabelCategoryID;
             set => this.LabelCategoryID = value;
         }	

		 [Key]
		 public int LabelCategoryID {get;set;}

		 public string LabelCategoryName {get;set;}

		 public DateTime CreateTime {get;set;}

		 public int OperatorID {get;set;}

		 public string Remark {get;set;}

		 public bool IsDeleted {get;set;}

		 public bool MultiSelect {get;set;}

		 public int CompanyID {get;set;}

		 public int DepartmentID {get;set;}

		 public int GroupID {get;set;}

		 public bool IsPublic {get;set;}

	}
}
