using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnetmyrd.Persistence.Interfaces
{
    public interface IDefaultQuery<DTODatabaseModel>
    {
        public List<DTODatabaseModel> GetAll();
        public DTODatabaseModel GetById(object Id);
    }
}
