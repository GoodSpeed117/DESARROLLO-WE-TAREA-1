using Microsoft.AspNetCore.Mvc;
using WebApiAviones.Entidades;

namespace WebApiAviones.Controllers
{

    [ApiController]
    [Route("api/aviones")]
    public class AvionesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Avion>> Get() {
            return new List<Avion>()
            {
                new Avion() {Id = 1 ,Name = "P-400"},
                new Avion() {Id = 2 ,Name = "B-434"}
            };
        }
    }
}
