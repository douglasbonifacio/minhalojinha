using LojinhaServer.Collections;
using MongoDB.Driver;

namespace LojinhaServer.Repositories;

    public class ProductRepository : IProductRepository
    {
        private readonly IMongoCollection<Product> _collection;

        public ProductRepository(IMongoDatabase mongoDatabase)
        {
           _collection = mongoDatabase.GetCollection<Product>("products"); 
        }
    }
