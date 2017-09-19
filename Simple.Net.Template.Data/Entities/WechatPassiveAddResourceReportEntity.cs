using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatPassiveAddResourceReport")]
	public partial class WechatPassiveAddResourceReportEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.WechatPassiveAddResourceReportId;
             set => this.WechatPassiveAddResourceReportId = value;
         }	

		 [Key]
		 public string WechatPassiveAddResourceReportId {get;set;}

		 public string CompanyId {get;set;}

		 public string DepartmentId {get;set;}

		 public string GroupId {get;set;}

		 public string EmployeeId {get;set;}

		 public string WechatUin {get;set;}

		 public string ReportDate {get;set;}

		 public string AddWechatApplyCount {get;set;}

		 public string AddWechatSuccessCount {get;set;}

		 public string CreateDate {get;set;}

		 public string UpdateDate {get;set;}

	}
}
