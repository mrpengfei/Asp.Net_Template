using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;
using Simple.Net.Template.Data.Entities;
using Simple.Net.Template.Data.IRepositories;


namespace Simple.Net.Template.Data.Repositories
{
	public partial class ResourceTaskRepository :DapperRepository<ResourceTaskEntity,int>, IResourceTaskRepository
	{
		public ResourceTaskRepository(ISessionManager session) : base(session)
        {
        }
	}
}
