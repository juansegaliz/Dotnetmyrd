using Dotnetmyrd.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dotnetmyrd.Persistence.Interfaces;
using Dotnetmyrd.DTO.Database;
using System.Data;
using Dotnetmyrd.Database;
using Dapper;

namespace Dotnetmyrd.Persistence.Queries
{
    public class QueryCustomers : IDefaultQuery<Customer>
    {
        private MainDatabaseConnection _mainDatabase;
        public QueryCustomers(MainDatabaseConnection mainDatabase) 
        {
            _mainDatabase = mainDatabase;
        }

        public List<Customer> GetAll()
        {
            List<Customer> toReturn = new List<Customer>();
            try 
            {
                using (IDbConnection dbConnection = _mainDatabase.Connection)
                {
                    dbConnection.Open();
                    string query = "SELECT * FROM Customers";
                    toReturn = dbConnection.Query<Customer>(query).ToList();
                }
            }
            catch (Exception ex)
            {

            }
            return toReturn;
        }

        public Customer GetById(object Id)
        {
            throw new NotImplementedException();
        }
    }
}
