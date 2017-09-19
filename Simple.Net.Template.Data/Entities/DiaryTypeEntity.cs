using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("DiaryType")]
	public partial class DiaryTypeEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.DiaryTypeID;
             set => this.DiaryTypeID = value;
         }	

		 [Key]
		 public string DiaryTypeID {get;set;}

		 public string DiaryTypeName {get;set;}

		 public string IsShow {get;set;}

	}
}
