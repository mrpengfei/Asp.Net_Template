using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ResourceSubPart")]
	public partial class ResourceSubPartEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.ID;
             set => this.ID = value;
         }	

		 [Key]
		 public string ID {get;set;}

		 public string ParentID {get;set;}

		 public string ResourceTypeID {get;set;}

		 public string ResourceSubTypeID {get;set;}

		 public string SubPartName {get;set;}

		 public string Description {get;set;}

		 public string Mark {get;set;}

		 public string Para {get;set;}

		 public string URL {get;set;}

		 public string CreateTime {get;set;}

		 public string IsOnline {get;set;}

		 public string UpdateTime {get;set;}

		 public string ReferTypeID {get;set;}

		 public string ReferURL {get;set;}

	}
}
