using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("Users_2o170801")]
	public partial class Users_2o170801Entity : BaseEntity<int>
	{
		 public string UserID {get;set;}

		 public string UserName {get;set;}

		 public string TrueName {get;set;}

		 public string Age {get;set;}

		 public string Province {get;set;}

		 public string City {get;set;}

		 public string Address {get;set;}

		 public string Gender {get;set;}

		 public string Job {get;set;}

		 public string OperatorID {get;set;}

		 public string UserTypeID {get;set;}

		 public string CreateTime {get;set;}

		 public string Updatetime {get;set;}

		 public string LastCallTime {get;set;}

		 public string UserFrom {get;set;}

		 public string IDCard {get;set;}

		 public string Momo {get;set;}

		 public string Momo1 {get;set;}

		 public string Momo2 {get;set;}

		 public string Career {get;set;}

		 public string SecondOprator {get;set;}

		 public string QQNumber {get;set;}

	}
}
