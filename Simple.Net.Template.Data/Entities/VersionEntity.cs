using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("Version")]
	public partial class VersionEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.VersionId;
             set => this.VersionId = value;
         }	

		 [Key]
		 public int VersionId {get;set;}

		 public string VersionNumber {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

	}
}
