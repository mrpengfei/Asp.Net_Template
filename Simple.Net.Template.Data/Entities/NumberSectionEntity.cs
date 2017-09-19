using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("NumberSection")]
	public partial class NumberSectionEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.ID;
             set => this.ID = value;
         }	

		 [Key]
		 public string ID {get;set;}

		 public string Number {get;set;}

		 public string CityId {get;set;}

		 public string CityName {get;set;}

		 public string Note {get;set;}

		 public string ProDicID {get;set;}

		 public string CityDicID {get;set;}

	}
}
