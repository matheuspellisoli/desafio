/*/
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System.Collections.Generic;


namespace desafio.connection {

    public class Connection{

    MongoClient _client;
    MongoServer _server;
    MongoDatabase _db;

    public  Connection(){

            _client = new MongoClient("mongodb://localhost:27017");
            _server = _client.GetServer();
            _db = _server.GetDatabase("desafio");  

            return(_db);
            
        }
    
    }
}
*/
  
