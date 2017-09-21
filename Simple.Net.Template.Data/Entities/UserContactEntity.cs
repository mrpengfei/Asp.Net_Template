using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserContact")]
	public partial class UserContactEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.UserContactID;
             set => this.UserContactID = value;
         }	

		 [Key]
		 public int UserContactID {get;set;}

		 public string UserID {get;set;}

		 public int ContacttypeID {get;set;}

		 public string Part1Value {get;set;}

		 public string Part2Value {get;set;}

		 public string Part3Value {get;set;}

		 public string Part4Value {get;set;}

		 public string ContactInfo {get;set;}

		 public string Attribution {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

		 public string Ismajor {get;set;}

		 public int ProDicId {get;set;}

		 public int CityDicId {get;set;}

	}
}
