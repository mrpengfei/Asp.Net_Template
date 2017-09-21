using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ViolationTypeConfig")]
	public partial class ViolationTypeConfigEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.ViolationTypeId;
             set => this.ViolationTypeId = value;
         }	

		 [Key]
		 public int ViolationTypeId {get;set;}

		 public string ViolationTypeName {get;set;}

		 public string ViolationTypeRemark {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

	}
}
