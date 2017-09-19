using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("RandomTimeList")]
	public partial class RandomTimeListEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.ID;
             set => this.ID = value;
         }	

		 [Key]
		 public string ID {get;set;}

		 public string LTime {get;set;}

		 public string LDateTime {get;set;}

	}
}
