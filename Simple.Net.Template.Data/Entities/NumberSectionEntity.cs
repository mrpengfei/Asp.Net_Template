using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("NumberSection")]
	public partial class NumberSectionEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.ID;
             set => this.ID = value;
         }	

		 [Key]
		 public int ID {get;set;}

		 public string Number {get;set;}

		 public int CityId {get;set;}

		 public string CityName {get;set;}

		 public string Note {get;set;}

		 public int ProDicID {get;set;}

		 public int CityDicID {get;set;}

	}
}
