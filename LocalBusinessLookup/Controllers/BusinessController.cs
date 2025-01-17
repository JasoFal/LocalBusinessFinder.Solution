using Microsoft.AspNetCore.Mvc;
using LocalBusiness.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cors;

namespace LocalBusiness.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BusinessesController : ControllerBase
    {
        private readonly LocalBusinessContext _db;
        public BusinessesController(LocalBusinessContext db)
        {
            _db = db;
        }

        // GET: api/businesses
        [EnableCors("GetPolicy")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Business>>> Get([FromQuery] string type, int pageNumber = 1)
        {
            IQueryable<Business> query = _db.Businesses.AsQueryable();

            if (type != null)
            {
                query = query.Where(entry => entry.Type == type);
            }

            return await query.OrderBy(entry => entry.Name)
                .Skip((pageNumber - 1) * 5)
                .Take(5)
                .ToListAsync();
        }

        // GET: api/businesses/7
        [EnableCors("GetPolicy")]
        [HttpGet("{id}")]
        public async Task<ActionResult<Business>> GetBusiness([FromRoute] int id)
        {
            Business business = await _db.Businesses.FindAsync(id);
            if (business == null)
            {
                return NotFound();
            }
            return business;
        }

        // POST: api/businesses
        [HttpPost]
        public async Task<ActionResult<Business>> Post(Business business)
        {
            _db.Businesses.Add(business);
            await _db.SaveChangesAsync();
            return CreatedAtAction(nameof(GetBusiness), new { id = business.BusinessId }, business);
        }
        
        // PUT: api/businesses/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Business business)
        {
            if (id != business.BusinessId)
            {
                return BadRequest();
            }
            _db.Businesses.Update(business);
            try
            {
                await _db.SaveChangesAsync();
            }
            catch
            {
                if (!BusinessExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }

        private bool BusinessExists(int id)
        {
            return _db.Businesses.Any(e => e.BusinessId == id);
        }

        // DELETE: api/businesses/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMessage(int id)
        {
            Business business = await _db.Businesses.FindAsync(id);
            if (business == null)
            {
                return NotFound();
            }
            else
            {
                _db.Businesses.Remove(business);
                await _db.SaveChangesAsync();
            }
            return NoContent();
        }
    }
}


