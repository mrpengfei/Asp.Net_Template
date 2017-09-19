using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatAutoAddResourceReport")]
	public partial class WechatAutoAddResourceReportEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.WechatAutoAddResourceReportId;
             set => this.WechatAutoAddResourceReportId = value;
         }	

		 [Key]
		 public string WechatAutoAddResourceReportId {get;set;}

		 public string CompanyId {get;set;}

		 public string DepartmentId {get;set;}

		 public string GroupId {get;set;}

		 public string EmployeeId {get;set;}

		 public string WechatUin {get;set;}

		 public string ReportDate {get;set;}

		 public string WaitPullResourceCount {get;set;}

		 public string HandleCount {get;set;}

		 public string HasWechatCount {get;set;}

		 public string AddWechatApplyCount {get;set;}

		 public string AddWechatSuccessCount {get;set;}

		 public string CreateDate {get;set;}

		 public string UpdateDate {get;set;}

	}
}
