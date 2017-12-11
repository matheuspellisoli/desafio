using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization;
using desafio.Models;

namespace desafio.tdlDAO {

    public class TdlDAO{

        MongoClient _client;
        MongoServer _server;
        MongoDatabase _db;
        MongoCollection<Tdl>  _collection;

        public TdlDAO(){            
            _client = new MongoClient("mongodb://localhost:27017");
            _server = _client.GetServer();
            _db = _server.GetDatabase("desafio"); 
             _collection = _db.GetCollection<Tdl>("tdl"); 
        }

        public List<Tdl> GetAll(){         
            var query = this._collection.Find(new BsonDocument()).ToListAsync();
            return query.Result;
        }
       
    }
}