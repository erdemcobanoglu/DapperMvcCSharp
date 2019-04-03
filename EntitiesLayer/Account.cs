using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer.Repository;

namespace EntitiesLayer
{
    public class Account :IDbModel
    {
        public int Id { get; set; }  
        public DateTime CreationDate { get; set; } 
        public decimal Balance { get; set; }

        //Relation
        public int CustomerId { get; set; }


        // using EntitiesLayer.Repository;
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
