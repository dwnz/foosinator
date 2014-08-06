using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace Foosinator.Models
{
    public class FastUnitOfWork : IDisposable
    {
        readonly IDbConnection _dataConnection;

        public FastUnitOfWork()
        {
            _dataConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString);
            _dataConnection.Open();
        }

        public IEnumerable<T> Query<T>(string sqlToExecute, DynamicParameters sqlParams)
        {
            return _dataConnection.Query<T>(
                sqlToExecute,
                sqlParams
            );
        }

        public SqlMapper.GridReader QueryMultiple(string sqlToExecute, DynamicParameters sqlParams)
        {
            return _dataConnection.QueryMultiple(sqlToExecute, sqlParams);
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        /// <filterpriority>2</filterpriority>
        public void Dispose()
        {
            _dataConnection.Close();
            _dataConnection.Dispose();
        }

        public T QuerySingle<T>(string sql, DynamicParameters dynamicParameters)
        {
            return _dataConnection.Query<T>(sql, dynamicParameters).FirstOrDefault();
        }

        public void Execute(string sql, DynamicParameters dynamicParameters)
        {
            _dataConnection.Execute(sql, dynamicParameters);
        }
    }
}