using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("Users")]
	public partial class UsersEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.UserID;
             set => this.UserID = value;
         }	

		 [Key]
		 public string UserID {get;set;}

		 public string UserName {get;set;}

		 public string TrueName {get;set;}

		 public int Age {get;set;}

		 public string Province {get;set;}

		 public string City {get;set;}

		 public string Address {get;set;}

		 public int Gender {get;set;}

		 public string Job {get;set;}

		 public int OperatorID {get;set;}

		 public int UserTypeID {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime Updatetime {get;set;}

		 public DateTime LastCallTime {get;set;}

		 public string UserFrom {get;set;}

		 public string IDCard {get;set;}

		 public string Momo {get;set;}

		 public string Momo1 {get;set;}

		 public string Momo2 {get;set;}

		 public string Career {get;set;}

		 public string SecondOprator {get;set;}

		 public string QQNumber {get;set;}

		 public int ResourceID {get;set;}

		 public string Mobile {get;set;}

		 public string Mobile2 {get;set;}

		 public string Telephone {get;set;}

		 public string Wechat {get;set;}

		 public string Email {get;set;}

		 public string CompanyName {get;set;}

		 public string CompanyPosition {get;set;}

	}
}
