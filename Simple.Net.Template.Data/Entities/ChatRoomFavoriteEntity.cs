using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ChatRoomFavorite")]
	public partial class ChatRoomFavoriteEntity : BaseEntity<string>
	{
 		 public override string Key
         {
             get => this.ChatRoomFavoriteId;
             set => this.ChatRoomFavoriteId = value;
         }	

		 [Key]
		 public string ChatRoomFavoriteId {get;set;}

		 public string FavoriteMiniImagePath {get;set;}

		 public string FavoriteOriginalPath {get;set;}

		 public string Type {get;set;}

		 public string EmployeeId {get;set;}

		 public string CreateDate {get;set;}

		 public string IsDelete {get;set;}

	}
}
