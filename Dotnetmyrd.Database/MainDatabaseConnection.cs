using Dotnetmyrd.Database.Classes;
using Dotnetmyrd.Database.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnetmyrd.Database
{
    public class MainDatabaseConnection : MSSQLDatabaseConnection
    {
        public MainDatabaseConnection(IConfiguration configuration) : base(configuration)
        {

        }


    }
}
