using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("LevelConfig")]
	public partial class LevelConfigEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.LevelConfigId;
             set => this.LevelConfigId = value;
         }	

		 [Key]
		 public string LevelConfigId {get;set;}

		 public string LevelConfigName {get;set;}

		 public string AssignCount {get;set;}

		 public string Priority {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

	}
}
