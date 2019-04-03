using EntitiesLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer 
{
    public class City : IDbModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ZipCode { get; set; }
        

        //Relation
        public int CountryId { get; set; }

        //using EntitiesLayer.Repository;
        #region Add IDbModel
        public AbstractDepperRepository Repository { get; set; }

        public void SetId(object id)
        {
            try
            {
                Id = (int)id;
            }
            catch
            {
                //Ignore
            }
        }

        public void SetRepository(AbstractDepperRepository dapperRepository)
        {
            Repository = dapperRepository;
        }
        #endregion
    }
}
