using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ContactTypeActionMapping")]
	public partial class ContactTypeActionMappingEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.ContactTypeActionMappingID;
             set => this.ContactTypeActionMappingID = value;
         }	

		 [Key]
		 public string ContactTypeActionMappingID {get;set;}

		 public string ContactTypeID {get;set;}

		 public string ContactActionID {get;set;}

	}
}
