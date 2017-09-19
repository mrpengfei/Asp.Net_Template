using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("Menu")]
	public partial class MenuEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.MenuID;
             set => this.MenuID = value;
         }	

		 [Key]
		 public string MenuID {get;set;}

		 public string MenuName {get;set;}

		 public string Link {get;set;}

		 public string Priority {get;set;}

		 public string ParentID {get;set;}

		 public string IsShow {get;set;}

	}
}
