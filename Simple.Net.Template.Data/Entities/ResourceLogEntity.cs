using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ResourceLog")]
	public partial class ResourceLogEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.ResourceLogID;
             set => this.ResourceLogID = value;
         }	

		 [Key]
		 public int ResourceLogID {get;set;}

		 public string Mobile {get;set;}

		 public string ResourceContent {get;set;}

		 public DateTime ImportTime {get;set;}

		 public int ResourceID {get;set;}

		 public int ResourceTypeID {get;set;}

		 public int ResourceSubTypeID {get;set;}

		 public string NeeAddMemo {get;set;}

		 public string Handled {get;set;}

		 public string ImprotedPool {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

		 public int EmployeeID {get;set;}

		 public string IsNew {get;set;}

		 public int GroupID {get;set;}

		 public int ResourceSubPartID {get;set;}

		 public int ContactTypeId {get;set;}

		 public string MobileMd5 {get;set;}

		 public int DepartmentID {get;set;}

		 public int CompanyID {get;set;}

		 public string Mobile2 {get;set;}

		 public string Telephone {get;set;}

		 public string Name {get;set;}

		 public int Gender {get;set;}

		 public string IdCard {get;set;}

		 public string QQ {get;set;}

		 public string Wechat {get;set;}

		 public string Email {get;set;}

		 public string Province {get;set;}

		 public string City {get;set;}

		 public string Address {get;set;}

		 public string CompanyName {get;set;}

		 public string CompanyPosition {get;set;}

		 public string ExpectSalary {get;set;}

		 public string ExpectJob {get;set;}

	}
}
