using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("Dictionary")]
	public partial class DictionaryEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.DictionaryId;
             set => this.DictionaryId = value;
         }	

		 [Key]
		 public string DictionaryId {get;set;}

		 public string ParentCode {get;set;}

		 public string Name {get;set;}

		 public string Code {get;set;}

		 public string Description {get;set;}

		 public string SerialNumber {get;set;}

		 public string IsDeleted {get;set;}

		 public string IsMerchantDictionary {get;set;}

		 public string CreateDate {get;set;}

	}
}
