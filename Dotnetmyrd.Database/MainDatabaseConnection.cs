using Dotnetmyrd.Database.Classes;
using Dotnetmyrd.Database.Interfaces;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnetmyrd.Database
{
    public class MainDatabaseConnection : MSSQLDatabaseConnection, IDatabaseConnector
    {
        public MainDatabaseConnection(IConfiguration configuration) : base(configuration)
        {

        }

        public IDbConnection Connection => new SqlConnection(GetConnectionString());
    }
}
