﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontakty
{
	public class PersonDatabase
	{
		private SQLiteAsyncConnection database;

		public PersonDatabase(string dbPath)
		{
			database = new SQLiteAsyncConnection(dbPath);
			database.CreateTableAsync<Person>().Wait();
		}


        public Task<List<Person>> GetItemsAsync()
		{
			return database.Table<Person>().ToListAsync();
		}

		public Task<List<Person>> GetItemsNotDoneAsync()
		{
			return database.QueryAsync<Person>("SELECT * FROM [TodoItem] WHERE [Done] = 0");
		}

		public Task<Person> GetItemAsync(int id)
		{
			return database.Table<Person>().Where(i => i.ID == id).FirstOrDefaultAsync();
		}

		public Task<int> SaveItemAsync(Person item)
		{
			if (item.ID != 0)
			{
				return database.UpdateAsync(item);
			}
			else
			{
				return database.InsertAsync(item);
			}
		}

		public Task<int> DeleteItemAsync(Person item)
		{
			return database.DeleteAsync(item);
		}
	}
}
