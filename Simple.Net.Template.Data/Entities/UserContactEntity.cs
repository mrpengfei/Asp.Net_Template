using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserContact")]
	public partial class UserContactEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.UserContactID;
             set => this.UserContactID = value;
         }	

		 [Key]
		 public string UserContactID {get;set;}

		 public string UserID {get;set;}

		 public string ContacttypeID {get;set;}

		 public string Part1Value {get;set;}

		 public string Part2Value {get;set;}

		 public string Part3Value {get;set;}

		 public string Part4Value {get;set;}

		 public string ContactInfo {get;set;}

		 public string Attribution {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

		 public string Ismajor {get;set;}

		 public string ProDicId {get;set;}

		 public string CityDicId {get;set;}

	}
}
