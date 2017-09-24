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

		 public decimal InitializeApplyCount {get;set;}

		 public decimal InitializeSuccessCount {get;set;}

		 public decimal AddressApplyCount {get;set;}

		 public decimal AddressSuccessCount {get;set;}

		 public decimal PassiveApplyCount {get;set;}

		 public decimal PassiveSuccessCount {get;set;}

		 public decimal SearchApplyCount {get;set;}

		 public decimal SearchSuccessCount {get;set;}

		 public decimal GroupApplyCount {get;set;}

		 public decimal GroupSuccessCount {get;set;}

		 public decimal ShareCardApplyCount {get;set;}

		 public decimal ShareCardSuccessCount {get;set;}

		 public decimal DeletedApplyCount {get;set;}

		 public decimal DeletedSuccessCount {get;set;}

		 public decimal UnKnownApplyCount {get;set;}

		 public decimal UnKnownSuccessCount {get;set;}

		 public decimal ActiveApplyCount {get;set;}

		 public decimal ActiveSuccessCount {get;set;}

		 public DateTime CreateDate {get;set;}

		 public DateTime UpdateDate {get;set;}

	}
}
