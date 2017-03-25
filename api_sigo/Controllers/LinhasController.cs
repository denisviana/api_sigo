using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using api_sigo.Context;
using api_sigo.Models;

namespace api_sigo.Controllers
{
    [Route("api/[controller]")]
    public class LinhasController : Controller
    {


        private DBConnect _context;

        public LinhasController(DBConnect context)
        {
            _context = context;
        }


        [HttpGet]
        public List<LinhaReduzida> Get()
        {

            List<LinhaReduzida> linhas = _context.view_linhas.ToList();

            return linhas;
        }

        [HttpGet("{idLinha}")]
        public Linha Get(int idLinha)
        {

            return _context.LinhaIndividual.Where(l => l.IdLinha == idLinha).FirstOrDefault();
        }


        
        [HttpGet]
        [Route("itinerario/{id:int}")]
        public List<Parada> GetItinerario(int id)
        {

            List<Parada> Itinerario = _context.ItinerarioLinha.Where(p => p.iditinerario == id).ToList();

            return Itinerario;

        }


    }
}
