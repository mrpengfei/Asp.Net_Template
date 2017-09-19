using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("Robot")]
	public partial class RobotEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.RobotId;
             set => this.RobotId = value;
         }	

		 [Key]
		 public string RobotId {get;set;}

		 public string RobotName {get;set;}

		 public string Api {get;set;}

		 public string ApiKey {get;set;}

		 public string IsValid {get;set;}

	}
}
