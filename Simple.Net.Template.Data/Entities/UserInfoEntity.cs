using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserInfo")]
	public partial class UserInfoEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.UserInfoId;
             set => this.UserInfoId = value;
         }	

		 [Key]
		 public string UserInfoId {get;set;}

		 public string UserId {get;set;}

		 public string IdNumber {get;set;}

		 public string Address {get;set;}

		 public string QQNumber {get;set;}

		 public string WechatNo {get;set;}

		 public string CeateDate {get;set;}

		 public string UpdateDate {get;set;}

		 public string TrueName {get;set;}

		 public string Gender {get;set;}

		 public string Email {get;set;}

	}
}
