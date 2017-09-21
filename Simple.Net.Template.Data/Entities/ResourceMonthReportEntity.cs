using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ResourceMonthReport")]
	public partial class ResourceMonthReportEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.ResourceMonthReportId;
             set => this.ResourceMonthReportId = value;
         }	

		 [Key]
		 public int ResourceMonthReportId {get;set;}

		 public string ResourceDate {get;set;}

		 public int EmployeeId {get;set;}

		 public int AssignCount {get;set;}

		 public int NewCount {get;set;}

		 public int MyCount {get;set;}

		 public int PublicCount {get;set;}

		 public int SucceedCount {get;set;}

		 public DateTime CreateDate {get;set;}

	}
}
