using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Zalupa2.Models;

namespace Zalupa2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoffeController : ControllerBase
    {
        private static List<Coffe> coffe = new List<Coffe>
        {
                new Coffe
                {
                    Id=1,
                    Name="Paradise",
                    Demand="latte with coconut and chocolate",
                    Score=99
                },
                 new Coffe
                {
                    Id=2,
                    Name="Berry",
                    Demand="latte with strawberries and peaches",
                    Score=87
                }
            };
        [HttpGet]
        public async Task<ActionResult<List<Coffe>>> Get()
        {
            return Ok(coffe);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Coffe>> Get(int id)
        {
            var coffes = coffe.Find(h => h.Id == id);
            if (coffes == null)
                return BadRequest("Coffee not found");
            return Ok(coffes);
        }

        [HttpPost]
        public async Task<ActionResult<List<Coffe>>> AddCoffe(Coffe coffes)
        {
            coffe.Add(coffes);
            return Ok(coffe);
        }
        [HttpPut]
        public async Task<ActionResult<List<Coffe>>> UpdateCoffe(Coffe request)
        {
            var coffes = coffe.Find(h => h.Id == request.Id);
            if (coffes == null)
                return BadRequest("Coffee not found");
            coffes.Name = request.Name;
            coffes.Demand = request.Demand;
            coffes.Score = request.Score;
            return Ok(coffe);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Coffe>>>Delete(int id)
        {
            var coffes = coffe.Find(h => h.Id == id);
            if (coffes == null)
                return BadRequest("Coffee not found");
            coffe.Remove(coffes);
            return Ok(coffe);
        }
    } 
  }

