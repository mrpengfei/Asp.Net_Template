using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;
using Simple.Net.Template.Data.Entities;


namespace Simple.Net.Template.Data.IRepositories
{
	public partial interface IResourceDayReportRepository : IRepository<ResourceDayReportEntity,int>
	{
	}
}
