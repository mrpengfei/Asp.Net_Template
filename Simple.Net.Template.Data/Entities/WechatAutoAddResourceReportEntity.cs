using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("WechatAutoAddResourceReport")]
	public partial class WechatAutoAddResourceReportEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.WechatAutoAddResourceReportId;
             set => this.WechatAutoAddResourceReportId = value;
         }	

		 [Key]
		 public int WechatAutoAddResourceReportId {get;set;}

		 public int CompanyId {get;set;}

		 public int DepartmentId {get;set;}

		 public int GroupId {get;set;}

		 public int EmployeeId {get;set;}

		 public string WechatUin {get;set;}

		 public DateTime ReportDate {get;set;}

		 public decimal WaitPullResourceCount {get;set;}

		 public decimal HandleCount {get;set;}

		 public decimal HasWechatCount {get;set;}

		 public decimal AddWechatApplyCount {get;set;}

		 public decimal AddWechatSuccessCount {get;set;}

		 public DateTime CreateDate {get;set;}

		 public DateTime UpdateDate {get;set;}

	}
}
