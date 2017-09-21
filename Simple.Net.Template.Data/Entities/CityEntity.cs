using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("City")]
	public partial class CityEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.CityID;
             set => this.CityID = value;
         }	

		 [Key]
		 public int CityID {get;set;}

		 public int ProvinceID {get;set;}

		 public string CityName {get;set;}

		 public int CityCode {get;set;}

	}
}
