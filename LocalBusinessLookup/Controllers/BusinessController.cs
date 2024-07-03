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
    }
}


