using MCTG.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Text.Json;

namespace MCTG.DB
{
    public class MongoDBService
    {
#warning todo
        private readonly IMongoCollection<User> _userCollection;
        // einbauen
        // mongodb://localhost:27017
       // mydatabaseName
        public MongoDBService(string connectionString, string databaseName)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);

            // "Get or Create" Collection
            _userCollection = GetOrCreateCollection<User>(database, "users");
        }

        // Methode, die eine Sammlung erstellt, falls sie nicht existiert
        private IMongoCollection<T> GetOrCreateCollection<T>(IMongoDatabase database, string collectionName)
        {
            // Überprüfen, ob die Sammlung existiert
            var collectionList = database.ListCollectionNames().ToList();
            if (!collectionList.Contains(collectionName))
            {
                // Sammlung erstellen, falls sie nicht existiert
                database.CreateCollection(collectionName);
            }

            // Referenz auf die Sammlung zurückgeben
            return database.GetCollection<T>(collectionName);
        }

        // Speichert eine Liste von User-Objekten
        public async Task SaveUsersAsync(List<User> users)
        {
            await _userCollection.InsertManyAsync(users);
        }

        // Lädt alle User-Objekte aus der Datenbank
        public async Task<List<User>> LoadAllUsersAsync()
        {
            return await _userCollection.Find(new BsonDocument()).ToListAsync();
        }

    }
}
