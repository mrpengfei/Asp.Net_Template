using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;
using Simple.Net.Template.Data.Entities;
using Simple.Net.Template.Data.IRepositories;


namespace Simple.Net.Template.Data.Repositories
{
	public partial class Department_CompanyRepository :DapperRepository<Department_CompanyEntity,int>, IDepartment_CompanyRepository
	{
		public Department_CompanyRepository(ISessionManager session) : base(session)
        {
        }
	}
}
