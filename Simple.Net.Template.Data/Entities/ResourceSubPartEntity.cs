using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ResourceSubPart")]
	public partial class ResourceSubPartEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.ID;
             set => this.ID = value;
         }	

		 [Key]
		 public int ID {get;set;}

		 public int ParentID {get;set;}

		 public int ResourceTypeID {get;set;}

		 public int ResourceSubTypeID {get;set;}

		 public string SubPartName {get;set;}

		 public string Description {get;set;}

		 public string Mark {get;set;}

		 public string Para {get;set;}

		 public string URL {get;set;}

		 public DateTime CreateTime {get;set;}

		 public int IsOnline {get;set;}

		 public DateTime UpdateTime {get;set;}

		 public int ReferTypeID {get;set;}

		 public string ReferURL {get;set;}

	}
}
