using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace DapperHelper
{
    public class DatabaseAccessHelper
    {
        public void DeleteByEntryId(IDbConnection connection, string sp, long Id)
        {
            var searchParameters = new { Id };
            Delete(connection, sp, searchParameters);
        }

        public void Delete<T>(IDbConnection connection, string sp, T searchParameters)
        {
            using (connection)
            {
                connection.Execute(sp, searchParameters, commandType: CommandType.StoredProcedure);
            }
        }

        public long Insert<T>(IDbConnection connection, string sp, T model)
        {
            using (connection)
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Id", 0, dbType: DbType.Int64, direction: ParameterDirection.Output);

                foreach (PropertyInfo pi in typeof(T).GetRuntimeProperties())
                {
                    if (pi.Name == "Id")
                    {
                        continue;
                    }

                    p.Add($"@{ pi.Name }", pi.GetValue(model));
                }

                connection.Execute(sp, p, commandType: CommandType.StoredProcedure);

                return p.Get<long>("Id");
            }
        }

        public T GetOne<T, U>(IDbConnection connection, string sp, U p)
        {
            IEnumerable<T> entries = GetFew<T, U>(connection, sp, p);

            if (entries.Count() == 0)
            {
                throw new NotFoundDbEntryException<T>();
            }

            if (entries.Count() > 1)
            {
                throw new FewDbEntriesWhenExpectedOnlyOneException<T>();
            }

            return entries.First();
        }

        public IEnumerable<T> GetFew<T>(IDbConnection connection, string sp)
        {
            using (connection)
            {
                return connection.Query<T>(
                    sp, commandType: CommandType.StoredProcedure);
            }
        }

        public IEnumerable<T> GetFew<T, U>(IDbConnection connection, string sp, U p)
        {
            using (connection)
            {
                return connection.Query<T>(
                    sp, p, commandType: CommandType.StoredProcedure);
            }
        }

        public void Update<T>(IDbConnection connection, string sp, T model)
        {
            using (connection)
            {
                connection.Execute(sp, model, commandType: CommandType.StoredProcedure);
            }
        }

        //private IDbConnection _connection;
        //private IDbTransaction _transaction;

        //public void StartTransaction(string connectionStringName)
        //{
        //    string connectionString = GetConnectonString(connectionStringName);

        //    _connection = new SqlConnection(connectionString);
        //    _connection.Open();

        //    _transaction = _connection.BeginTransaction();

        //    isClosed = false;
        //}

        //public List<T> LoadDataInTransaction<T, U>(string storedProcedure, U parameters)
        //{
        //    List<T> rows = _connection.Query<T>(storedProcedure, parameters,
        //        commandType: CommandType.StoredProcedure, transaction: _transaction).ToList();

        //    return rows;
        //}

        //public void SaveDataInTransaction<T>(string storedProcedure, T parameters)
        //{
        //    _connection.Execute(storedProcedure, parameters,
        //        commandType: CommandType.StoredProcedure, transaction: _transaction);
        //}

        //private bool isClosed = false;
        //private IConfiguration _config;

        //public void CommitTransaction()
        //{
        //    _transaction?.Commit();
        //    _connection?.Close();

        //    isClosed = true;
        //}

        //public void Rollbacktransaction()
        //{
        //    _transaction?.Rollback();
        //    _connection?.Close();

        //    isClosed = true;
        //}

        //public void Dispose()
        //{
        //    if (isClosed == false)
        //    {
        //        try
        //        {
        //            CommitTransaction();
        //        }
        //        catch (Exception)
        //        {
        //            // TODO - Log this issue
        //        }
        //    }

        //    _transaction = null;
        //    _transaction = null;
        //}

        //// Open connection / Start transaction
        //// Load using the transaction
        //// Save  using the transaction
        //// Close connection/stop the transactio
        //// Dispose
    }
}
