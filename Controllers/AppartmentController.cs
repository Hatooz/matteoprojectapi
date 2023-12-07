using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MatteoRbProject.Context;
using MatteoRbProject.Models;
using MatteoRbProject.ExtentionMethods;

namespace MatteoRbProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppartmentController : ControllerBase
    {
        private readonly MatteoRbProjectContext _context;

        public AppartmentController(MatteoRbProjectContext context)
        {
            _context = context;
        }

        // GET: api/Appartment
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Appartment>>> GetAppartments()
        {
          if (_context.Appartments == null)
          {
              return NotFound();
          }
            return await _context.Appartments.ToListAsync();
        }

        // GET: api/Appartment/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AppartmentDTO>> GetAppartment(Guid id)
        {
          if (_context.Appartments == null)
          {
              return NotFound();
          }
            var appartment = await _context.Appartments.FindAsync(id);

            if (appartment == null)
            {
                return NotFound();
            }
            appartment.Advert = await _context.Adverts.Where(ad => ad.AppartmentId == appartment.Id).FirstOrDefaultAsync();
            appartment.Address = await _context.Addresses.Where(adr => adr.Appartments.Contains(appartment)).FirstOrDefaultAsync();
            appartment.QueueRule = await _context.QueueRules.Where(q => q.Appartments.Contains(appartment)).FirstOrDefaultAsync();

            return appartment.ToDto();
        }

        [HttpGet("byproperty/{propertyId}")]
        public async Task<ActionResult<List<AppartmentDTO>>> GetAppartmentsByPropertyId(Guid propertyId)
        {
            
            var appartments = await _context.Appartments.Where(appartment => appartment.PropertyId == propertyId).ToListAsync();
            foreach (var appartment in appartments)
            {
                
                appartment.Advert = await _context.Adverts.Where(ad => ad.AppartmentId == appartment.Id).FirstOrDefaultAsync();
                appartment.Address = await _context.Addresses.Where(adr => adr.Appartments.Contains(appartment)).FirstOrDefaultAsync();
                appartment.QueueRule = await _context.QueueRules.Where(q => q.Appartments.Contains(appartment)).FirstOrDefaultAsync();
            }

             

            return appartments.Select(ap => ap.ToDto()).ToList();
        }

        [HttpGet("hasAdvert")]
        public async Task<ActionResult<List<AppartmentDTO>>> GetAppartmentsWithAdvert()
        {

            var appartments = await _context.Appartments.Where(appartment => appartment.AdvertId != null).ToListAsync();
            foreach (var appartment in appartments)
            {

                appartment.Advert = await _context.Adverts.Where(ad => ad.AppartmentId == appartment.Id).FirstOrDefaultAsync();
                appartment.Address = await _context.Addresses.Where(adr => adr.Appartments.Contains(appartment)).FirstOrDefaultAsync();
                appartment.QueueRule = await _context.QueueRules.Where(q => q.Appartments.Contains(appartment)).FirstOrDefaultAsync();
                appartment.Applications = await _context.Applications.Where(appl => appl.AppartmentId == appartment.Id).ToListAsync();
            }



            return appartments.Select(ap => ap.ToDto()).ToList();
        }

        // PUT: api/Appartment/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAppartment(Guid id, [FromBody] UpdateAppartmentDTO appartmentDTO){
           

            try
            {
                var apparment = await _context.Appartments.FindAsync(id);
                var queueRule = await _context.QueueRules.FindAsync(appartmentDTO.QueueRuleId);

                apparment.QueueRule = queueRule;
                apparment.QueueRuleId = queueRule.Id;
                _context.Update(apparment);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AppartmentExists(id))
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

        // POST: api/Appartment
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Appartment>> PostAppartment(Appartment appartment)
        {
          if (_context.Appartments == null)
          {
              return Problem("Entity set 'MatteoRbProjectContext.Appartments'  is null.");
          }
            _context.Appartments.Add(appartment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAppartment", new { id = appartment.Id }, appartment);
        }

        // DELETE: api/Appartment/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAppartment(Guid id)
        {
            if (_context.Appartments == null)
            {
                return NotFound();
            }
            var appartment = await _context.Appartments.FindAsync(id);
            if (appartment == null)
            {
                return NotFound();
            }

            _context.Appartments.Remove(appartment);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AppartmentExists(Guid id)
        {
            return (_context.Appartments?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
