using EntitiesLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserInterfaceMVC.Models
{
    public sealed class MvcDbHelper
    {
        /// <summary>
        ///  add => using EntitiesLayer.Repository;
        /// </summary>
        private static volatile AbstractDepperRepository _repositoryInstance;
        private static object _syncRoot = new object();
        public MvcDbHelper()
        {

        }
        public static AbstractDepperRepository Repository
        {
            get
            {
                if(_repositoryInstance == null)
                {
                    lock (_syncRoot)
                    {
                        if(_repositoryInstance == null)
                            _repositoryInstance = new DapperRepository("DefaultConnection");
                    }
                }

                return _repositoryInstance;
            }
        }
        
    }

}