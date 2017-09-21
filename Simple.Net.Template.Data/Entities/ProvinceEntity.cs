using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("Province")]
	public partial class ProvinceEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.ProvinceID;
             set => this.ProvinceID = value;
         }	

		 [Key]
		 public int ProvinceID {get;set;}

		 public string ProvinceName {get;set;}

	}
}
