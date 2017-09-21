using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ResourceRecycleLog")]
	public partial class ResourceRecycleLogEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.ResourceRecycleLogId;
             set => this.ResourceRecycleLogId = value;
         }	

		 [Key]
		 public int ResourceRecycleLogId {get;set;}

		 public int ResourceId {get;set;}

		 public string WechatUin {get;set;}

		 public int CompanyId {get;set;}

		 public int DepartmentId {get;set;}

		 public int GroupId {get;set;}

		 public int EmployeeId {get;set;}

		 public DateTime PullTime {get;set;}

		 public string HasWechat {get;set;}

		 public string IsAddWechat {get;set;}

		 public DateTime AddWechatTime {get;set;}

		 public int ResourceTypeId {get;set;}

		 public int ResourceSubTypeId {get;set;}

		 public DateTime RecycleDate {get;set;}

		 public string RecycleReason {get;set;}

		 public int OperatorId {get;set;}

		 public string IpAddress {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

	}
}
