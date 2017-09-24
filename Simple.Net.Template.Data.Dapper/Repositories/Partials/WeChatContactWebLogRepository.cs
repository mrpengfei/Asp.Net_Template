using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;
using Simple.Net.Template.Data.Entities;
using Simple.Net.Template.Data.IRepositories;


namespace Simple.Net.Template.Data.Repositories
{
	public partial class WeChatContactWebLogRepository :DapperRepository<WeChatContactWebLogEntity,int>, IWeChatContactWebLogRepository
	{
		public WeChatContactWebLogRepository(ISessionManager session) : base(session)
        {
        }
	}
}
