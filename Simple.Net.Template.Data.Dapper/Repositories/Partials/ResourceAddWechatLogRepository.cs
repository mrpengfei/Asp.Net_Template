using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;
using Simple.Net.Template.Data.Entities;
using Simple.Net.Template.Data.Repositories;


namespace Novel.Core.Dapper.Repository
{
	public partial class ResourceAddWechatLogRepository :DapperRepository<ResourceAddWechatLogEntity>, IResourceAddWechatLogRepository
	{
		public ResourceAddWechatLogRepository(ISessionManager session) : base(session)
        {
        }
	}
}
