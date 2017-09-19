using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("CallInfo")]
	public partial class CallInfoEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.CallInfoID;
             set => this.CallInfoID = value;
         }	

		 [Key]
		 public string CallInfoID {get;set;}

		 public string CallID {get;set;}

		 public string StaffID {get;set;}

		 public string CallType {get;set;}

		 public string CustomerNumber {get;set;}

		 public string ServiceNumber {get;set;}

		 public string SkillNumber {get;set;}

		 public string UserID {get;set;}

		 public string IsNew {get;set;}

		 public string IsMulti {get;set;}

		 public string CallStart {get;set;}

		 public string CallEnd {get;set;}

		 public string Duration {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

		 public string RoleName {get;set;}

		 public string BCRecID {get;set;}

		 public string RecordAddress {get;set;}

	}
}
