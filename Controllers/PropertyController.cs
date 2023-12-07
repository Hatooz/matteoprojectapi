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
    public class PropertyController : ControllerBase
    {
        private readonly MatteoRbProjectContext _context;

        public PropertyController(MatteoRbProjectContext context)
        {
            _context = context;
        }

        // GET: api/Property
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PropertyDTO>>> GetProperties()
        {
          if (_context.Properties == null)
          {
              return NotFound();
          }
          var properties = await _context.Properties.ToListAsync();
            foreach ( var property in properties )
            {
                property.QueueRule = await _context.QueueRules.Where(rule => rule.Id == property.QueueRuleId).FirstAsync();
                property.Appartments = await _context.Appartments.Where(appartment => appartment.PropertyId == property.Id).ToListAsync();
                property.Addresses = await _context.Addresses.Where(address => address.PropertyId == property.Id).ToListAsync();
                _context.Update(property);
            }
            await _context.SaveChangesAsync();
            return await _context.Properties.Select(property => property.ToDto()).ToListAsync();
        }

        // GET: api/Property/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Property>> GetProperty(Guid id)
        {
          if (_context.Properties == null)
          {
              return NotFound();
          }
            var @property = await _context.Properties.FindAsync(id);

            if (@property == null)
            {
                return NotFound();
            }

            return @property;
        }

        // PUT: api/Property/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProperty(Guid id, [FromBody] UpdatePropertyDTO propertyDTO)
        {
           
            try
            {
                var property = await _context.Properties.FindAsync(id);
                property.Appartments = await _context.Appartments.Where(ap => ap.PropertyId == id).ToListAsync();
                var QueueRule = await _context.QueueRules.Where(q => q.Id == propertyDTO.QueueRuleId).FirstAsync();
                property.QueueRuleId = propertyDTO.QueueRuleId;
                property.QueueRule = QueueRule;
                foreach (var apparment in property.Appartments)
                {
                    apparment.QueueRule = QueueRule;
                    apparment.QueueRuleId = propertyDTO.QueueRuleId;
                    _context.Update(apparment);
                }
                _context.Update(property);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PropertyExists(id))
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

        // POST: api/Property
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Property>> PostProperty([FromBody] CreatePropertyDTO propertyDTO)
        {
          if (_context.Properties == null)
          {
              return Problem("Entity set 'MatteoRbProjectContext.Properties'  is null.");
          }
            var property = new Property()
            {
                ObjectNumber = propertyDTO.ObjectNumber,
                LMNumber = propertyDTO.LMNumber,
                QueueRuleId = propertyDTO.QueueRuleId,
            };
            _context.Properties.Add(property);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProperty", new { id = @property.Id }, @property);
        }

        // DELETE: api/Property/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProperty(Guid id)
        {
            if (_context.Properties == null)
            {
                return NotFound();
            }
            var @property = await _context.Properties.FindAsync(id);
            if (@property == null)
            {
                return NotFound();
            }

            _context.Properties.Remove(@property);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PropertyExists(Guid id)
        {
            return (_context.Properties?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
