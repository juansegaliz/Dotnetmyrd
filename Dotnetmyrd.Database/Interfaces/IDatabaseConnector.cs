using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnetmyrd.Database.Interfaces
{
    public interface IDatabaseConnector
    {
        public IDbConnection Connection { get; }
    }
}
