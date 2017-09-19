using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("SystemConfig")]
	public partial class SystemConfigEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.SystemConfigID;
             set => this.SystemConfigID = value;
         }	

		 [Key]
		 public string SystemConfigID {get;set;}

		 public string ConfigKey {get;set;}

		 public string ConfigValue {get;set;}

		 public string ConfigDescription {get;set;}

	}
}
