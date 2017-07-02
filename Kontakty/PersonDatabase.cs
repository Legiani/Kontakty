using SQLite;
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
            database.CreateTableAsync<Kategorie>().Wait();
            database.CreateTableAsync<Vazebni>().Wait();
		}


        public Task<List<Person>> GetItemsAsync()
		{
			return database.Table<Person>().ToListAsync();
		}

		public Task<List<Vazebni>> GetVazebniAsync()
		{
            return database.Table<Vazebni>().ToListAsync();
		}

        public Task<Kategorie> GetKategorie(int id)
		{
            return database.Table<Kategorie>().Where(i => i.ID == id).FirstOrDefaultAsync();
		}

        public Task<List<Kategorie>> GetKategorieAsync()
		{
            return database.Table<Kategorie>().ToListAsync();
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

        public Task<int> SaveVazebniAsync(Vazebni item)
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

        public Task<int> SaveKategorieAsync(Kategorie item)
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
