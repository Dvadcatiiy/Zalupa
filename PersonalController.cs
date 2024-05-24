using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Zalupa2.Models;

namespace Zalupa2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalController : ControllerBase
    {
        private static List<Personal> pers = new List<Personal>
        {
                new Personal
                {
                    Id=1,
                    FirstName="Volkova",
                    Name="Maria",
                    LastName="Alexandrovna",
                    Age=17,
                },
                 new Personal
                {
                    Id=2,
                    FirstName="Ivanova",
                    Name="Anna",
                    LastName="Sergeevna",
                    Age=18
                }
        };
        [HttpGet]
        public async Task<ActionResult<List<Personal>>> Get()
        {
            return Ok(pers);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Personal>> Get(int id)
        {
            var perses = pers.Find(h => h.Id == id);
            if (perses == null)
                return BadRequest("Personal not found");
            return Ok(perses);
        }
        [HttpPost]
        public async Task<ActionResult<List<Personal>>> AddPersonal(Personal perses)
        {
            pers.Add(perses);
            return Ok();
        }
        [HttpPut]
        public async Task<ActionResult<List<Personal>>> UpdatePersonal(Personal request)
        {
            var perses = pers.Find(h => h.Id == request.Id);
            if (perses == null)
                return BadRequest("Personal not found");
            perses.FirstName = request.FirstName;
            perses.Name = request.Name;
            perses.LastName = request.LastName;
            perses.Age = request.Age;
            return Ok(pers);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Personal>>> Delete(int id)
        {
            var perses = pers.Find(h => h.Id == id);
            if (perses == null)
                return BadRequest("Personal not found");
            pers.Remove(perses);
            return Ok(pers);
        }
    }
}
