using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("LevelConfig")]
	public partial class LevelConfigEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.LevelConfigId;
             set => this.LevelConfigId = value;
         }	

		 [Key]
		 public int LevelConfigId {get;set;}

		 public string LevelConfigName {get;set;}

		 public int AssignCount {get;set;}

		 public int Priority {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

	}
}
