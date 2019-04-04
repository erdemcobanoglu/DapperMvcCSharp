using EntitiesLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    
    public class Customer  : IDbModel
    {
       public int Id { get; set; }
       public string FirstName { get; set; } 
       public string LastName { get; set; }
       public string Email { get; set; }
       public string PhoneNumber { get; set; } 
       
        public string FullName
        {
            get
            {
                return LastName + ", " + LastName;
            }
        }


        public int RelatedAccountId { get; set; }
        public int RelatedCityId { get; set; }


        //using EntitiesLayer.Repository; add 
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
