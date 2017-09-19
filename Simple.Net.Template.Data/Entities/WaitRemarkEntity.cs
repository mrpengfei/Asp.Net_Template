using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WaitRemark")]
	public partial class WaitRemarkEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.WaitRemarkId;
             set => this.WaitRemarkId = value;
         }	

		 [Key]
		 public string WaitRemarkId {get;set;}

		 public string UserId {get;set;}

		 public string WechatUid {get;set;}

		 public string Nickname {get;set;}

		 public string Username {get;set;}

		 public string State {get;set;}

	}
}
