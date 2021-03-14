using API.MongoDB.Data.Collections;
using API.MongoDB.ViewModels;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using System;
using System.Linq;

namespace API.MongoDB.Controllers
{
    [Route("api/[controller]")]
    public class InfectadosController : MainController
    {
        Data.MongoDB _mongoDB;
        IMongoCollection<Infectado> _infectadosCollection;

        public InfectadosController(Data.MongoDB mongoDB)
        {
            _mongoDB = mongoDB;
            _infectadosCollection = _mongoDB.DB.GetCollection<Infectado>(typeof(Infectado).Name.ToLower());
        }

        [HttpPost]
        public ActionResult Post([FromBody] InfectadoViewModel infectadoViewModel)
        {
            var infectado = new Infectado(infectadoViewModel.DataNascimento, infectadoViewModel.Sexo, infectadoViewModel.Latitude, infectadoViewModel.Longitude);

            _infectadosCollection.InsertOne(infectado);

            return StatusCode(201, "Infectado adicionado com sucesso");
        }

        [HttpGet]
        public ActionResult Get()
        {
            var infectados = _infectadosCollection.Find(Builders<Infectado>.Filter.Empty).ToList();

            return Ok(infectados);
        }

        [HttpPut]
        public ActionResult Put([FromBody] InfectadoViewModel infectadoViewModel)
        {
            _infectadosCollection.UpdateOne(Builders<Infectado>.Filter
                .Where(i => i.DataNascimento == infectadoViewModel.DataNascimento), Builders<Infectado>.Update.Set("sexo", infectadoViewModel.Sexo));

            return Ok("Atualizado com sucesso");
        }

        [HttpDelete("{dataNasc}")]
        public ActionResult Delete(DateTime dataNsc)
        {
            _infectadosCollection.DeleteOne(Builders<Infectado>.Filter
                .Where(i => i.DataNascimento == dataNsc));

            return Ok("Excluído com sucesso");
        }
    }
}
