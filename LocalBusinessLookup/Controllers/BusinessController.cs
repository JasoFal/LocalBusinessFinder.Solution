using Microsoft.AspNetCore.Mvc;

namespace LocalBusiness.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BusinessesController : ControllerBase
    {
        private readonly LocalBusinessLookupContext _db;
        public BusinessesController(LocalBusinessContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Business>>> Get()
        {
            return await _db.Businesses.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Businesses>> GetMessage([FromRoute] int id)
        {
            Businesses business = await _db.Businesses.FindAsync(id);
            if (business == null)
            {
                return NotFound();
            }
            return business;
        }
    }
}


