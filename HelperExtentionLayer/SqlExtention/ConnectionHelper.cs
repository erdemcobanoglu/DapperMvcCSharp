using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperExtentionLayer
{
    public class ConnectionHelper
    {
      
        
        private static readonly Lazy<ConnectionHelper> Lazy = new Lazy<ConnectionHelper>(() => new ConnectionHelper());

        public static ConnectionHelper Instance => Lazy.Value;

        SqlConnection sqlCon = new SqlConnection(@"Data Source= ; initial Catalog= ;Integrated Security = True;");

        private ConnectionHelper()
        {
            InActive = true;
            Active = false;
        }

        private bool InActive { get; set; }
        private bool Active { get; set; }


        public void SqlOpen()
        {
            if (InActive)
                sqlCon.Open();
        }

        public void SqlClose()
        {
            if (Active)
                sqlCon.Close();
        }


    }
}
