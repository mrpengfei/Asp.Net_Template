using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ResourceDayReport")]
	public partial class ResourceDayReportEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.ResourceDayReportId;
             set => this.ResourceDayReportId = value;
         }	

		 [Key]
		 public int ResourceDayReportId {get;set;}

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
