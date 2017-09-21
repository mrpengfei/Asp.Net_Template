using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ViolationKeyWordConfig")]
	public partial class ViolationKeyWordConfigEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.ViolationKeyWordId;
             set => this.ViolationKeyWordId = value;
         }	

		 [Key]
		 public int ViolationKeyWordId {get;set;}

		 public string ViolationKeyWordName {get;set;}

		 public string DelViolationKeyWordName {get;set;}

		 public int ViolationTypeId {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

	}
}
