using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;
using Simple.Net.Template.Data.Entities;
using Simple.Net.Template.Data.Repositories;


namespace Novel.Core.Dapper.Repository
{
	public partial class Department_CompanyRepository :DapperRepository<Department_CompanyEntity>, IDepartment_CompanyRepository
	{
		public Department_CompanyRepository(ISessionManager session) : base(session)
        {
        }
	}
}
