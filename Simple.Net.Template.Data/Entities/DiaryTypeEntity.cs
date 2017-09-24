using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("DiaryType")]
	public partial class DiaryTypeEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.DiaryTypeID;
             set => this.DiaryTypeID = value;
         }	

		 [Key]
		 public int DiaryTypeID {get;set;}

		 public string DiaryTypeName {get;set;}

		 public bool IsShow {get;set;}

	}
}
