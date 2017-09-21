using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("RandomTimeList")]
	public partial class RandomTimeListEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.ID;
             set => this.ID = value;
         }	

		 [Key]
		 public int ID {get;set;}

		 public string LTime {get;set;}

		 public DateTime LDateTime {get;set;}

	}
}
