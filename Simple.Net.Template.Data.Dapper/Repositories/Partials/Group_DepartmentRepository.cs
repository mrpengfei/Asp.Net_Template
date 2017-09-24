using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;
using Simple.Net.Template.Data.Entities;
using Simple.Net.Template.Data.IRepositories;


namespace Simple.Net.Template.Data.Repositories
{
	public partial class Group_DepartmentRepository :DapperRepository<Group_DepartmentEntity,int>, IGroup_DepartmentRepository
	{
		public Group_DepartmentRepository(ISessionManager session) : base(session)
        {
        }
	}
}
