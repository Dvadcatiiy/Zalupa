using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Zalupa2.Models;

namespace Zalupa2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProviderController : ControllerBase
    {
        private static List<Provider> prov = new List<Provider>
        {
                new Provider
                {
                    Id=1,
                    NameOrg="Koko",
                    Product="latte",
                },
                 new Provider
                {
                    Id=2,
                    NameOrg="Rorola",
                    Product="Coffee",
                }
            };
        [HttpGet]
        public async Task<ActionResult<List<Provider>>> Get()
        {
            return Ok(prov);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Provider>> Get(int id)
        {
            var proves = prov.Find(h => h.Id == id);
            if (proves == null)
                return BadRequest("Provider not found");
            return Ok(proves);
        }
        [HttpPost]
        public async Task<ActionResult<List<Provider>>> AddProvider(Provider proves)
        {
            prov.Add(proves);
            return Ok(prov);
        }
        [HttpPut]
        public async Task<ActionResult<List<Provider>>> UpdateProvider(Provider request)
        {
            var proves = prov.Find(h => h.Id == request.Id);
            if (prov == null)
                return BadRequest("Provider not found");
            proves.NameOrg = request.NameOrg;
            proves.Product = request.Product;
            return Ok(prov);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Provider>>> Delete(int id)
        {
            var proves = prov.Find(h => h.Id == id);
            if (proves == null)
                return BadRequest("Provider not found");
            prov.Remove(proves);
            return Ok(prov);
        }
    }
}
