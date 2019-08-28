using System;
using SQLite;
//
using System.Collections.Generic;
using System.Threading.Tasks;
using HolaMundo.Modelos;

namespace HolaMundo.Datos
{
	public abstract class SQLiteDb
	{
		private SQLiteAsyncConnection database;

		public SQLiteDb(string conexion)
		{
			database = new SQLiteAsyncConnection(conexion);

			database.CreateTableAsync<Producto>().Wait();
		}

		public Task<List<Producto>> ListAsync()
		{
			// SELECT
			return database.Table<Producto>().ToListAsync();
		}

		public Task<int> InsertAsync(Producto item)
		{
			// INSERT
			return database.InsertAsync(item);
		}

		public Task<int> DeleteAsync(Producto item)
		{
			// DELETE
			return database.DeleteAsync(item);
		}

		public async Task DeleteAllAsync()
		{
			// DELETE * FROM [Productos]
			await database.DeleteAllAsync<Producto>();
		}
	}
}
