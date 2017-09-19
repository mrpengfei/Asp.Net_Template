using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("Label")]
	public partial class LabelEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.LabelID;
             set => this.LabelID = value;
         }	

		 [Key]
		 public string LabelID {get;set;}

		 public string LabelName {get;set;}

		 public string CreateTime {get;set;}

		 public string OperatorID {get;set;}

		 public string LabelCategoryID {get;set;}

		 public string Remark {get;set;}

		 public string IsDeleted {get;set;}

		 public string CompanyID {get;set;}

		 public string DepartmentID {get;set;}

		 public string GroupID {get;set;}

		 public string IsPublic {get;set;}

	}
}
