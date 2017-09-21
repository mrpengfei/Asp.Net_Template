using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace Simple.Net.Template.Data.Entities
{
	[Table("ChatRoomFavorite")]
	public partial class ChatRoomFavoriteEntity : BaseEntity<int>
	{
 		 public override int Key
         {
             get => this.ChatRoomFavoriteId;
             set => this.ChatRoomFavoriteId = value;
         }	

		 [Key]
		 public int ChatRoomFavoriteId {get;set;}

		 public string FavoriteMiniImagePath {get;set;}

		 public string FavoriteOriginalPath {get;set;}

		 public int Type {get;set;}

		 public int EmployeeId {get;set;}

		 public DateTime CreateDate {get;set;}

		 public string IsDelete {get;set;}

	}
}
