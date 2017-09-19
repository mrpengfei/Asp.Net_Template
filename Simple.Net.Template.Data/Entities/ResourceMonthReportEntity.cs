using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ResourceMonthReport")]
	public partial class ResourceMonthReportEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.ResourceMonthReportId;
             set => this.ResourceMonthReportId = value;
         }	

		 [Key]
		 public string ResourceMonthReportId {get;set;}

		 public string ResourceDate {get;set;}

		 public string EmployeeId {get;set;}

		 public string AssignCount {get;set;}

		 public string NewCount {get;set;}

		 public string MyCount {get;set;}

		 public string PublicCount {get;set;}

		 public string SucceedCount {get;set;}

		 public string CreateDate {get;set;}

	}
}
