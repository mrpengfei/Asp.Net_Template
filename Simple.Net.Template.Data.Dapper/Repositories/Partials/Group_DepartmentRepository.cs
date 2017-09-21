using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;
using Simple.Net.Template.Data.Entities;
using Simple.Net.Template.Data.Repositories;


namespace Novel.Core.Dapper.Repository
{
	public partial class Group_DepartmentRepository :DapperRepository<Group_DepartmentEntity>, IGroup_DepartmentRepository
	{
		public Group_DepartmentRepository(ISessionManager session) : base(session)
        {
        }
	}
}