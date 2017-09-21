using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("CompanySystemConfig")]
	public partial class CompanySystemConfigEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.CompanySystemConfigID;
             set => this.CompanySystemConfigID = value;
         }	

		 [Key]
		 public int CompanySystemConfigID {get;set;}

		 public string ConfigKey {get;set;}

		 public string ConfigValue {get;set;}

		 public string ConfigDescription {get;set;}

		 public int CompanyID {get;set;}

	}
}
