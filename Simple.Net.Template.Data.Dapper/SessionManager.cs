using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Autofac;

namespace Simple.Net.Template.Data.Dapper
{
    public class SessionManager : ISessionManager
    {
        private ILifetimeScope lifetimeScope;
        public SessionManager(ILifetimeScope lifetimeScope)
        {
            this.lifetimeScope = lifetimeScope;
        }

        public IDbTransaction Transaction
        {
            get; set;
        }

        public IDbConnection GetConnection(string connectionName = null)
        {
            if (string.IsNullOrEmpty(connectionName))
            {
                return lifetimeScope.Resolve<IDbConnection>();
            }
            return lifetimeScope.ResolveNamed<IDbConnection>(connectionName);
        }
    }
}
