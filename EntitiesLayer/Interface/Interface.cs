using EntitiesLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public interface IDbModel
    {
        AbstractDepperRepository Repository { get; set; }
        void SetId(object id);
        void SetRepository(AbstractDepperRepository dapperRepository);
    }
}
