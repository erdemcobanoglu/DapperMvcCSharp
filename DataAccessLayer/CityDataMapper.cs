using EntitiesLayer;
using HelperExtentionLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class CityDataMapper : IDataMapper<City>
    {
        // add sql connection helper
        ConnectionHelper sqlConn = ConnectionHelper.Instance;

        public bool Delete(City item)
        {
            throw new NotImplementedException();
        }

        public List<City> GetAll()
        {
            throw new NotImplementedException();
        }

        public City GetById(City item)
        {
            throw new NotImplementedException();
        }

        public bool Insert(City item)
        {
            throw new NotImplementedException();
        }

        public bool Update(City item)
        {
            throw new NotImplementedException();
        }
    }
}
