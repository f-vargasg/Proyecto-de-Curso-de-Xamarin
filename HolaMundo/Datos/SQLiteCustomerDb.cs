using HolaMundo.Modelos;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo.Datos
{
    public abstract class SQLiteCustomerDb
    {
        private SQLiteAsyncConnection database;
        public SQLiteCustomerDb(string conexion)
        {
            database = new SQLiteAsyncConnection(conexion);

            database.CreateTableAsync<Customer>().Wait();
        }

        public Task<List<Customer>> ListAsync()
        {
            // SELECT
            return database.Table<Customer>().ToListAsync();
        }

        public Task<int> InsertAsync(Customer item)
        {
            // INSERT
            return database.InsertAsync(item);
        }

        public Task<int> DeleteAsync(Customer item)
        {
            // DELETE
            return database.DeleteAsync(item);
        }

        public async Task DeleteAllAsync()
        {
            // DELETE * FROM [Customer]
            await database.DeleteAllAsync<Customer>();
        }
    }
}
