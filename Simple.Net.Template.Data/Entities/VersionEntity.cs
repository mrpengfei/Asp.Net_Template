using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("Version")]
	public partial class VersionEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.VersionId;
             set => this.VersionId = value;
         }	

		 [Key]
		 public string VersionId {get;set;}

		 public string VersionNumber {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

	}
}
