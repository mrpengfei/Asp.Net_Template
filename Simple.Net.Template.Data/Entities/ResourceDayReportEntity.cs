using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ResourceDayReport")]
	public partial class ResourceDayReportEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.ResourceDayReportId;
             set => this.ResourceDayReportId = value;
         }	

		 [Key]
		 public string ResourceDayReportId {get;set;}

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
