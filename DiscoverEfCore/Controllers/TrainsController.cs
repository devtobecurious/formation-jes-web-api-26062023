using DiscoverEfCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DiscoverEfCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainsController : ControllerBase
    {
        private readonly DefaultDbContext context;

        public TrainsController(DefaultDbContext context)
        {
            this.context = context;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var query = from item in this.context.Trains
                        select item;

            var query2 = this.context.Trains!.ToList();

            Task<List<Train>> listTrainAsync = query.ToListAsync();

            // du code ici

            var list = await listTrainAsync;


            return this.Ok(list);
        }
    }
}
