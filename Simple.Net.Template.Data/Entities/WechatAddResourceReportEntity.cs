using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatAddResourceReport")]
	public partial class WechatAddResourceReportEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.WechatAddResourceReportId;
             set => this.WechatAddResourceReportId = value;
         }	

		 [Key]
		 public int WechatAddResourceReportId {get;set;}

		 public int CompanyId {get;set;}

		 public int DepartmentId {get;set;}

		 public int GroupId {get;set;}

		 public int EmployeeId {get;set;}

		 public string WechatUin {get;set;}

		 public DateTime ReportDate {get;set;}

		 public string InitializeApplyCount {get;set;}

		 public string InitializeSuccessCount {get;set;}

		 public string AddressApplyCount {get;set;}

		 public string AddressSuccessCount {get;set;}

		 public string PassiveApplyCount {get;set;}

		 public string PassiveSuccessCount {get;set;}

		 public string SearchApplyCount {get;set;}

		 public string SearchSuccessCount {get;set;}

		 public string GroupApplyCount {get;set;}

		 public string GroupSuccessCount {get;set;}

		 public string ShareCardApplyCount {get;set;}

		 public string ShareCardSuccessCount {get;set;}

		 public string DeletedApplyCount {get;set;}

		 public string DeletedSuccessCount {get;set;}

		 public string UnKnownApplyCount {get;set;}

		 public string UnKnownSuccessCount {get;set;}

		 public string ActiveApplyCount {get;set;}

		 public string ActiveSuccessCount {get;set;}

		 public DateTime CreateDate {get;set;}

		 public DateTime UpdateDate {get;set;}

	}
}
