using Dotnetmyrd.Database.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnetmyrd.Database.Classes
{
    public class MSSQLDatabaseConnection : IDatabaseConnection
    {
        private IConfiguration _configuration;
        
        public MSSQLDatabaseConnection(IConfiguration configuration) 
        {
            _configuration = configuration;
        }

        //MSSQLDatabaseConnectionString is a secret key on secrets.json
        public string GetConnectionString() => _configuration["MSSQLDatabaseConnectionString"];
    }
}
