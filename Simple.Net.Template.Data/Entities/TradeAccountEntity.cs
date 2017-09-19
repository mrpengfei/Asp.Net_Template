using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("TradeAccount")]
	public partial class TradeAccountEntity : BaseEntity
	{
 		 public override int Key
         {
             get => this.TradeAccountID;
             set => this.TradeAccountID = value;
         }	

		 [Key]
		 public string TradeAccountID {get;set;}

		 public string ExchangeID {get;set;}

		 public string UserID {get;set;}

		 public string VirtualAccount {get;set;}

		 public string RealAccount {get;set;}

		 public string VirtualCTime {get;set;}

		 public string RealCTime {get;set;}

		 public string Fund {get;set;}

		 public string ActivateTime {get;set;}

		 public string UserName {get;set;}

		 public string Gender {get;set;}

		 public string Identify {get;set;}

		 public string CreateTime {get;set;}

		 public string UpdateTime {get;set;}

		 public string VirtualFundPassword {get;set;}

		 public string VirtualLoginPassword {get;set;}

		 public string VirtualTelTrustPassword {get;set;}

		 public string RealFundPassword {get;set;}

		 public string RealLoginPassword {get;set;}

		 public string RealTelTrustPassword {get;set;}

		 public string Mobile {get;set;}

		 public string Amount {get;set;}

		 public string BankID {get;set;}

		 public string BankCardID {get;set;}

		 public string Province {get;set;}

		 public string City {get;set;}

		 public string District {get;set;}

		 public string TradeAccountUserTypeID {get;set;}

		 public string CloseTime {get;set;}

		 public string OpenTypeID {get;set;}

		 public string FirstResourceSubTypeID {get;set;}

		 public string FirstResourceInTime {get;set;}

		 public string FirstResourceTypeID {get;set;}

		 public string LastEmployeeID {get;set;}

		 public string FirstResourceSubPartID {get;set;}

		 public string ActivateSequenceID {get;set;}

		 public string OpenState {get;set;}

		 public string CountryId {get;set;}

		 public string TradeAccountTypeCode {get;set;}

	}
}
