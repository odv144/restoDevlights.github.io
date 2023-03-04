using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace restoApp_AL_WepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservasController : ControllerBase
    {
        // GET: api/<ReservasController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    // Código para obtener todas las reservas desde la base de datos
        //    // ...
            
        //    return new string[] { "value1", "value2" };
        //}

        //Metodo para obtener las reservas
        [HttpGet]
        public int ObtenerTodasLasReservas()
        {
            int capacidadLocal = 1000;
            return capacidadLocal;
        }


        // GET api/<ReservasController>/5
        [HttpGet("{id}")]
        public string ObtenerTodasLasReservasId(int id)
        {
            // Código para obtener una reserva por ID desde la base de datos
            // ...
            return "informacion de reservas especifica del id";
            //if (reserva == null)
            //{
            //    return NotFound(); // Retorna un código de estado
            //}
        }

        // POST api/<ReservasController>
        //Crear reservas
        [HttpPost]
        public void CrearReserva([FromBody] string value)
        {
            //codigo para crear una reserva de mesas consus comensales
            //devolveria informacion de la reserve segun algun modelo creado
            //return CreatedAtAction(nameof(ObtenerReservaPorId), new { id = reserva.Id }, reserva); // Retorna un código de estado 201 y la nueva reserva creada
        }

        // PUT api/<ReservasController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ReservasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
