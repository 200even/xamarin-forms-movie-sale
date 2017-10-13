using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using MovieSaleApp.Models;

namespace MovieSaleApp
{
    public class MovieDatabase
    {
        readonly SQLiteAsyncConnection database;
        public MovieDatabase Instance;

        public MovieDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Movie>().Wait();
        }

        public Task<List<Movie>> GetItemsAsync()
        {
            return database.Table<Movie>().ToListAsync();
        }

        public Task<List<Movie>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<Movie>("SELECT * FROM [Movie] WHERE [Done] = 0");
        }

        public Task<Movie> GetItemAsync(int id)
        {
            return database.Table<Movie>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(Movie item)
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

        public Task<int> DeleteItemAsync(Movie item)
        {
            return database.DeleteAsync(item);
        }
    }
}