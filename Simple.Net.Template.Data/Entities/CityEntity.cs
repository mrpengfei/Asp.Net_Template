using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("City")]
	public partial class CityEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.CityID;
             set => this.CityID = value;
         }	

		 [Key]
		 public string CityID {get;set;}

		 public string ProvinceID {get;set;}

		 public string CityName {get;set;}

		 public string CityCode {get;set;}

	}
}
