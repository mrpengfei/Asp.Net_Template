using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("LabelCategory")]
	public partial class LabelCategoryEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.LabelCategoryID;
             set => this.LabelCategoryID = value;
         }	

		 [Key]
		 public string LabelCategoryID {get;set;}

		 public string LabelCategoryName {get;set;}

		 public string CreateTime {get;set;}

		 public string OperatorID {get;set;}

		 public string Remark {get;set;}

		 public string IsDeleted {get;set;}

		 public string MultiSelect {get;set;}

		 public string CompanyID {get;set;}

		 public string DepartmentID {get;set;}

		 public string GroupID {get;set;}

		 public string IsPublic {get;set;}

	}
}
