using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Data.Repositories
{
    public class CompradorRepository : IRepository<Comprador>

    {

        private const string COLLECTION_NAME = "class";
        private readonly Connection _connection;

        public CompradorRepository(Connection dbConnection)
        {
            _connection = dbConnection;
        }
        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Comprador> FindAll()
        {
            throw new NotImplementedException();
        }

        public Comprador FindByID(string id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Comprador entity)
        {
            throw new NotImplementedException();
        }

        public Comprador Update(Comprador entity)
        {
            throw new NotImplementedException();
        }


    }
}
