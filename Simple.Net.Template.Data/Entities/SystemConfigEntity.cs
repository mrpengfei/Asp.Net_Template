using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("SystemConfig")]
	public partial class SystemConfigEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.SystemConfigID;
             set => this.SystemConfigID = value;
         }	

		 [Key]
		 public int SystemConfigID {get;set;}

		 public string ConfigKey {get;set;}

		 public string ConfigValue {get;set;}

		 public string ConfigDescription {get;set;}

	}
}
