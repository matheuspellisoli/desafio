using System;
using MongoDB.Bson;

namespace desafio.Models
{
    public class Tdl
    {
     public ObjectId  _id {get; set;}

    public string tdl {get; set;}

     public string description {get; set;}

     public string type {get; set;}

    }
}