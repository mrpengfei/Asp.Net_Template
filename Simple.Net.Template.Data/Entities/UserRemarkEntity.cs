using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserRemark")]
	public partial class UserRemarkEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.RemarkId;
             set => this.RemarkId = value;
         }	

		 [Key]
		 public string RemarkId {get;set;}

		 public string RemarkName {get;set;}

		 public string UserId {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

		 public string WxUin {get;set;}

	}
}
