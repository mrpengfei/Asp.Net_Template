using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("UserRemark")]
	public partial class UserRemarkEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.RemarkId;
             set => this.RemarkId = value;
         }	

		 [Key]
		 public int RemarkId {get;set;}

		 public string RemarkName {get;set;}

		 public string UserId {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

		 public string WxUin {get;set;}

	}
}
