using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;


namespace StampCard.DataStore
{

    public class CoffeStore
    {
        private readonly string _collectionName= "DrinkedCoffees";

        private readonly string _databaseName = "DrinkedCoffees.db";

        private string GetConnectionString()
        {
            var path = FileSystem.Current.AppDataDirectory;

            var fullPath = Path.Combine(path, _databaseName);

            var connectionString = $"Filename={fullPath}";

            return connectionString;
        }
        public void Save(int count)
        {
            using var db = new LiteDatabase(GetConnectionString());

            var collection = db.GetCollection<CoffeDto>(_collectionName);

            collection.DeleteAll();

            collection.Insert(new CoffeDto
            {
                DrinkedCoffe = count
            });
        }

        public int Read()
        {
            using var db = new LiteDatabase(GetConnectionString());

            var collection = db.GetCollection<CoffeDto>(_collectionName);

            var list = collection.FindAll().ToList();
            if(list.Count == 0)
            {
                return 0;
            }
            return list.First().DrinkedCoffe;            
        }
    }
}
