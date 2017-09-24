using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("Robot")]
	public partial class RobotEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.RobotId;
             set => this.RobotId = value;
         }	

		 [Key]
		 public int RobotId {get;set;}

		 public string RobotName {get;set;}

		 public string Api {get;set;}

		 public string ApiKey {get;set;}

		 public bool IsValid {get;set;}

	}
}
