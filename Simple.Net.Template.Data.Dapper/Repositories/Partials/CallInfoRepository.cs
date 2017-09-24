using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;
using Simple.Net.Template.Data.Entities;
using Simple.Net.Template.Data.IRepositories;


namespace Simple.Net.Template.Data.Repositories
{
	public partial class CallInfoRepository :DapperRepository<CallInfoEntity,int>, ICallInfoRepository
	{
		public CallInfoRepository(ISessionManager session) : base(session)
        {
        }
	}
}
