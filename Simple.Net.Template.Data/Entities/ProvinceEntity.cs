using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("Province")]
	public partial class ProvinceEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.ProvinceID;
             set => this.ProvinceID = value;
         }	

		 [Key]
		 public string ProvinceID {get;set;}

		 public string ProvinceName {get;set;}

	}
}
