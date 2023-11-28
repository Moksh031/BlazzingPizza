using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlazingPizza.Data;
namespace BlazingPizza.Controllers
{
    [Route("specials")]
    [ApiController]
    public class SpecialsController
    {
        private readonly PizzaStoreContext _db4;

        public SpecialsController(PizzaStoreContext db4)
        {
            _db4 = db4;
        }

        [HttpGet]
        public async Task<ActionResult<List<PizzaSpecial>>> GetSpecials()
        {
            return (await _db4.Specials.ToListAsync()).OrderByDescending(s => s.BasePrice).ToList();
        }
    }
}

