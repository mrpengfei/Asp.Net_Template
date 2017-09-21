using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;
using Simple.Net.Template.Data.Entities;
using Simple.Net.Template.Data.Repositories;


namespace Novel.Core.Dapper.Repository
{
	public partial class UserOrderInAccountRecordRepository :DapperRepository<UserOrderInAccountRecordEntity>, IUserOrderInAccountRecordRepository
	{
		public UserOrderInAccountRecordRepository(ISessionManager session) : base(session)
        {
        }
	}
}
