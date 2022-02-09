using InaApp1.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace InaApp1.Controllers
{
    [ApiController]
    [Route("api/clientes")]
    public class ClienteController : ControllerBase
    {
        public ClienteController()
        {
        }

        [HttpGet]
        public ActionResult getAll()
        {



            return Ok("estoy en getAll");
           // return StatusCode(201);
        }
        [HttpGet("byId")]
        public ActionResult getById()
        {



            return Ok("estoy en getby");
            //return StatusCode(201);
        }
        [HttpPost]
        public ActionResult post([FromBody] ClientesVM clienteVm)
        {

            //validar datos de entrada 

            //enviar a service
            return Ok("estoy en post");
            //return StatusCode(201);
        }
    }
}
