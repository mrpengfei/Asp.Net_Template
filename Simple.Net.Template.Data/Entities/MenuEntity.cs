using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("Menu")]
	public partial class MenuEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.MenuID;
             set => this.MenuID = value;
         }	

		 [Key]
		 public int MenuID {get;set;}

		 public string MenuName {get;set;}

		 public string Link {get;set;}

		 public int Priority {get;set;}

		 public int ParentID {get;set;}

		 public bool IsShow {get;set;}

	}
}
