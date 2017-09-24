using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;
using Simple.Net.Template.Data.Entities;
using Simple.Net.Template.Data.IRepositories;


namespace Simple.Net.Template.Data.Repositories
{
	public partial class WechatContactBakRepository :DapperRepository<WechatContactBakEntity,int>, IWechatContactBakRepository
	{
		public WechatContactBakRepository(ISessionManager session) : base(session)
        {
        }
	}
}
