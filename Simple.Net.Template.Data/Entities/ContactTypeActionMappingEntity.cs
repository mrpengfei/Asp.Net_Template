using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ContactTypeActionMapping")]
	public partial class ContactTypeActionMappingEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.ContactTypeActionMappingID;
             set => this.ContactTypeActionMappingID = value;
         }	

		 [Key]
		 public int ContactTypeActionMappingID {get;set;}

		 public int ContactTypeID {get;set;}

		 public int ContactActionID {get;set;}

	}
}
