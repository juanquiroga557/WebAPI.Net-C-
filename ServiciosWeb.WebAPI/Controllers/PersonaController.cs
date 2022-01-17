using ServiciosWeb.Datos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServiciosWeb.WebAPI.Controllers
{
    public class PersonaController : ApiController
    {
        LibreriaConnection BD = new LibreriaConnection();

        [HttpGet]
        public IEnumerable<Persona> Get()
        {
            var listado = BD.Persona.ToList();

            return listado;
        }

        [HttpGet]
        public Persona GetById(int id)
        {
            var persona = BD.Persona.FirstOrDefault(x => x.Id == id);

            return persona;
        }

    }
}
