using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ContactType")]
	public partial class ContactTypeEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.ContactTypeID;
             set => this.ContactTypeID = value;
         }	

		 [Key]
		 public string ContactTypeID {get;set;}

		 public string ContactTypeName {get;set;}

		 public string Part1 {get;set;}

		 public string Part2 {get;set;}

		 public string Part3 {get;set;}

		 public string Part4 {get;set;}

		 public string RegxExpression {get;set;}

		 public string ErrorMessage {get;set;}

	}
}
