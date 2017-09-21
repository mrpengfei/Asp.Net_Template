using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("TradeAccount")]
	public partial class TradeAccountEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.TradeAccountID;
             set => this.TradeAccountID = value;
         }	

		 [Key]
		 public int TradeAccountID {get;set;}

		 public int ExchangeID {get;set;}

		 public string UserID {get;set;}

		 public string VirtualAccount {get;set;}

		 public string RealAccount {get;set;}

		 public DateTime VirtualCTime {get;set;}

		 public DateTime RealCTime {get;set;}

		 public int Fund {get;set;}

		 public DateTime ActivateTime {get;set;}

		 public string UserName {get;set;}

		 public int Gender {get;set;}

		 public string Identify {get;set;}

		 public DateTime CreateTime {get;set;}

		 public DateTime UpdateTime {get;set;}

		 public string VirtualFundPassword {get;set;}

		 public string VirtualLoginPassword {get;set;}

		 public string VirtualTelTrustPassword {get;set;}

		 public string RealFundPassword {get;set;}

		 public string RealLoginPassword {get;set;}

		 public string RealTelTrustPassword {get;set;}

		 public string Mobile {get;set;}

		 public string Amount {get;set;}

		 public int BankID {get;set;}

		 public string BankCardID {get;set;}

		 public string Province {get;set;}

		 public string City {get;set;}

		 public string District {get;set;}

		 public int TradeAccountUserTypeID {get;set;}

		 public DateTime CloseTime {get;set;}

		 public string OpenTypeID {get;set;}

		 public int FirstResourceSubTypeID {get;set;}

		 public DateTime FirstResourceInTime {get;set;}

		 public int FirstResourceTypeID {get;set;}

		 public int LastEmployeeID {get;set;}

		 public int FirstResourceSubPartID {get;set;}

		 public string ActivateSequenceID {get;set;}

		 public string OpenState {get;set;}

		 public int CountryId {get;set;}

		 public string TradeAccountTypeCode {get;set;}

	}
}
