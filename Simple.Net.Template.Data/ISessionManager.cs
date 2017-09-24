using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Simple.Net.Template.Data
{
    public interface ISessionManager
    {
        IDbTransaction Transaction { get; set; }

        IDbConnection GetConnection(string connectionName = null);
    }
}
