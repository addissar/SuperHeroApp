//using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroApp.Entities;

namespace SuperHeroApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetAllHeroes()
        {
            var heroes = new List<SuperHero>
            {
                new SuperHero
                {
                    Id = 1,
                    Name = "Spider-man",
                    FirstName = "Peter",
                    LastName = "Parker",
                    Place = "New York"
                }
            };
            return Ok(heroes);
        }
    }
}
