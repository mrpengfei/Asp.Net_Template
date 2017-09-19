using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ViolationTypeConfig")]
	public partial class ViolationTypeConfigEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.ViolationTypeId;
             set => this.ViolationTypeId = value;
         }	

		 [Key]
		 public string ViolationTypeId {get;set;}

		 public string ViolationTypeName {get;set;}

		 public string ViolationTypeRemark {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

	}
}
