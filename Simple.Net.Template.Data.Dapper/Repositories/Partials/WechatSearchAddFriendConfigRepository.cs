using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;
using Simple.Net.Template.Data.Entities;
using Simple.Net.Template.Data.Repositories;


namespace Novel.Core.Dapper.Repository
{
	public partial class WechatSearchAddFriendConfigRepository :DapperRepository<WechatSearchAddFriendConfigEntity>, IWechatSearchAddFriendConfigRepository
	{
		public WechatSearchAddFriendConfigRepository(ISessionManager session) : base(session)
        {
        }
	}
}