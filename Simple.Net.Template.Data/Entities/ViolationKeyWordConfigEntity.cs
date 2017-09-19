using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ViolationKeyWordConfig")]
	public partial class ViolationKeyWordConfigEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.ViolationKeyWordId;
             set => this.ViolationKeyWordId = value;
         }	

		 [Key]
		 public string ViolationKeyWordId {get;set;}

		 public string ViolationKeyWordName {get;set;}

		 public string DelViolationKeyWordName {get;set;}

		 public string ViolationTypeId {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

	}
}
