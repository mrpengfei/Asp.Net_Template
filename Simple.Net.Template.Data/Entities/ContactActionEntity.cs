using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ContactAction")]
	public partial class ContactActionEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.ContactActionID;
             set => this.ContactActionID = value;
         }	

		 [Key]
		 public int ContactActionID {get;set;}

		 public string ContactActionName {get;set;}

		 public string Description {get;set;}

		 public string OutputAction {get;set;}

	}
}
