using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("CompanySystemConfig")]
	public partial class CompanySystemConfigEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.CompanySystemConfigID;
             set => this.CompanySystemConfigID = value;
         }	

		 [Key]
		 public string CompanySystemConfigID {get;set;}

		 public string ConfigKey {get;set;}

		 public string ConfigValue {get;set;}

		 public string ConfigDescription {get;set;}

		 public string CompanyID {get;set;}

	}
}
