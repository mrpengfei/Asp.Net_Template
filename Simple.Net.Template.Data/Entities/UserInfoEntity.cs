using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserInfo")]
	public partial class UserInfoEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.UserInfoId;
             set => this.UserInfoId = value;
         }	

		 [Key]
		 public int UserInfoId {get;set;}

		 public string UserId {get;set;}

		 public string IdNumber {get;set;}

		 public string Address {get;set;}

		 public string QQNumber {get;set;}

		 public string WechatNo {get;set;}

		 public DateTime CeateDate {get;set;}

		 public DateTime UpdateDate {get;set;}

		 public string TrueName {get;set;}

		 public int Gender {get;set;}

		 public string Email {get;set;}

	}
}
