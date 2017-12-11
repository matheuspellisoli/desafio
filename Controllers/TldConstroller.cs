using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using desafio.Models;
using System;
using MongoDB.Bson;
namespace desafio.Controllers
{
    [Route("api/[Controller]")]

    public class TdlController : Controller{
        private static List<Tdl> _tdl;


        static TdlController(){
                _tdl = new List<Tdl>();

                _tdl.Add(new Tdl(){
                    _id = new ObjectId(),
                    tdl = ".com",
                    type = "internacional",
                    description = "Usada para domínios para uso geral"
                });

                _tdl.Add(new Tdl(){
                    _id = new ObjectId(),
                    tdl = ".com.br",
                    type = "nacional",
                    description = "Usada para domínios para uso geral"
                });

            }
    
            
        [HttpGet]
        public IEnumerable<Tdl> GetAll(){
            
           
            return _tdl.AsReadOnly();
        }

        [HttpGet("{id}", Name = "GetTdl")]
        public ActionResult GetById(ObjectId id){
            var item = _tdl.Find(x => x._id == id);
            if (item == null){
                return NotFound();
            }
            return new ObjectResult(item);
        }

        [HttpPost]

        public IActionResult Create([FromBody] Tdl item){
            if(item == null){
                return BadRequest();
            }

            item._id = new ObjectId();

            _tdl.Add(item);

            return new ObjectResult(item);

        }


        
        }
}

