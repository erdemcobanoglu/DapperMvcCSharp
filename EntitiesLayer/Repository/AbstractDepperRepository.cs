using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace EntitiesLayer.Repository
{
    /// <summary>
    /// addd =>   System.Configuration.ConfigurationManager
    /// add => Dapper
    /// </summary>
    public abstract class AbstractDepperRepository : IDisposable
    {
        //using System.Data;
        public readonly IDbConnection DbConnection;


        //Initialization Properties & Methods
        #region Base'den giden methodlarımız
        protected AbstractDepperRepository()
        {

            // add Dapper Repository =>  System.Configuration.ConfigurationManager
            DbConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"]
                 .ConnectionString);
        }
        protected AbstractDepperRepository(string connectionName)
        {
            DbConnection = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionName].ConnectionString);
        }

        protected AbstractDepperRepository(IDbConnection dbConnection)
        {
            DbConnection = dbConnection;
        }
        #endregion

        // Crud operations
        #region Crud Methods

     
        public TEntity Insert<TEntity>(string sqlQuery, TEntity item) where TEntity : IDbModel
        {
            try
            {
                // add Dapper library
                var result = DbConnection.ExecuteScalar(sqlQuery, item);
                item.SetId(result);
            }
            catch (Exception ex)
            {
                //Todo Add Log
            }
            return item;
        }
        
        public IEnumerable<TEntity> GetAllItems<TEntity>(string sqlQuery) where TEntity :IDbModel
        {
            try
            {
                return DbConnection.Query<TEntity>(sqlQuery).ToList();
            }
            catch (Exception ex)
            {
                // Todo Add Log
                return null;
            } 
        }

        public IEnumerable<TEntity> GetItems<TEntity>(string sqlQuery, object parameters) where TEntity : IDbModel
        {
            try
            {
                return DbConnection.Query<TEntity>(sqlQuery, parameters).ToList();
            }
            catch (Exception ex)
            {
                // Todo Add Log
                return null;
            }
        }

        public TEntity Update<TEntity>(string sqlQuery, TEntity item) where TEntity : IDbModel
        {
            try
            {
                DbConnection.Execute(sqlQuery, item);
            }
            catch (Exception ex)
            {
                // Todo Add Log 
            }
            return item;
        }
        public void Delete<TEntity>(string sqlQuery, TEntity item) where TEntity : IDbModel
        {
            try
            {
                DbConnection.Execute(sqlQuery, item);
            }
            catch (Exception ex)
            {
                // Todo Add Log 
            }
        }
        public void ExecuteNonQuery(string sqlQuery, object parameter)
        {
            try
            {
                DbConnection.Execute(sqlQuery, parameter);
            }
            catch (Exception ex)
            { 
                // Todo Add Log 
            }
        }
        public void ExecuteNonQuery(string sqlQuery)
        {
            try
            {
                DbConnection.Execute(sqlQuery);
            }
            catch (Exception ex)
            {
                // Todo Add Log 
            }
        }
        public int Execute(string sqlQuery, object parameter)
        {
            try
            {
                return DbConnection.ExecuteScalar<int>(sqlQuery, parameter);
            }
            catch (Exception ex)
            {
                // Todo Add Log 
                return -1;
            }
        }
        public object Execute<T>(string sqlQuery, object parameter)
        {
            try
            {
                return DbConnection.ExecuteScalar<T>(sqlQuery, parameter);
            }
            catch (Exception ex)
            {
                // Todo Add Log 
                return null;
            }
        }
        #endregion
        // Crud operations
        #region IDisposible Implementation
        public virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                //IDbConnection
                DbConnection?.Dispose();
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
