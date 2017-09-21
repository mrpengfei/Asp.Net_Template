using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;
using Simple.Net.Template.Data.Entities;
using Simple.Net.Template.Data.Repositories;


namespace Novel.Core.Dapper.Repository
{
	public partial class WechatGroupSendConfig Repository :DapperRepository<WechatGroupSendConfig Entity>, IWechatGroupSendConfig Repository
	{
		public WechatGroupSendConfig Repository(ISessionManager session) : base(session)
        {
        }
	}
}
