using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("CallInfo")]
	public partial class CallInfoEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.CallInfoID;
             set => this.CallInfoID = value;
         }	

		 [Key]
		 public int CallInfoID {get;set;}

		 public string CallID {get;set;}

		 public string StaffID {get;set;}

		 public string CallType {get;set;}

		 public string CustomerNumber {get;set;}

		 public string ServiceNumber {get;set;}

		 public string SkillNumber {get;set;}

		 public string UserID {get;set;}

		 public string IsNew {get;set;}

		 public string IsMulti {get;set;}

		 public DateTime CallStart {get;set;}

		 public DateTime CallEnd {get;set;}

		 public int Duration {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

		 public string RoleName {get;set;}

		 public string BCRecID {get;set;}

	}
}
