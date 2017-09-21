using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;
using Simple.Net.Template.Data.Entities;
using Simple.Net.Template.Data.Repositories;


namespace Novel.Core.Dapper.Repository
{
	public partial class CompanyRepository :DapperRepository<CompanyEntity>, ICompanyRepository
	{
		public CompanyRepository(ISessionManager session) : base(session)
        {
        }
	}
}
