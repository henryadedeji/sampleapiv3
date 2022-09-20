using Microsoft.AspNetCore.Mvc;

namespace SampleApi.Controllers

{

   [ApiController]
   [Route("[controller]")]

   public class PersonsController : ControllerBase

   {

      [HttpGet]

      public IActionResult Get()
      {
         var persons = new string[]{
            "Henry",
            "Amaka Apolos",
            "Nnoma madam",
            "Jamal",
            "Blessing",
            "Sheryl"
            };
         return Ok(persons);
      }
   }
}