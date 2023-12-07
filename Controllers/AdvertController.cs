using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MatteoRbProject.Context;
using MatteoRbProject.Models;

namespace MatteoRbProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvertController : ControllerBase
    {
        private readonly MatteoRbProjectContext _context;

        public AdvertController(MatteoRbProjectContext context)
        {
            _context = context;
        }

        // GET: api/Advert
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Advert>>> GetAdverts()
        {
          if (_context.Adverts == null)
          {
              return NotFound();
          }
            return await _context.Adverts.ToListAsync();
        }

        // GET: api/Advert/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Advert>> GetAdvert(Guid id)
        {
          if (_context.Adverts == null)
          {
              return NotFound();
          }
            var advert = await _context.Adverts.FindAsync(id);

            if (advert == null)
            {
                return NotFound();
            }

            return advert;
        }

        // PUT: api/Advert/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdvert(Guid id, [FromBody] UpdateAdvertDTO advertDTO)
        {
             
            try
            {
                var advert = await _context.Adverts.FindAsync(id);
                if (advert == null)
                {
                    return NotFound();
                }
                advert.AdvertText = advertDTO.AdvertText;
                advert.RentalDate = advertDTO.RentalDate;
                advert.PublishedAt ??= DateTime.Now;
                _context.Adverts.Update(advert);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdvertExists(id))
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

        // POST: api/Advert
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Advert>> PostAdvert([FromBody] CreateAdvertDTO advertDTO)
        {
            var appartment = await _context.Appartments.FindAsync(advertDTO.AppartmentId);

            Advert advert = new()
            {
                Appartment = appartment,
                AppartmentId = appartment.Id,
                PublishedAt = DateTime.Now,
                RentalDate = advertDTO.RentalDate,
                AdvertText = advertDTO.AdvertText,

            };
            

            _context.Adverts.Add(advert);
            appartment.AdvertId = advert.Id;
            _context.Update(appartment);
            await _context.SaveChangesAsync();
            return advert;
        }

        // DELETE: api/Advert/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAdvert(Guid id)
        {
            if (_context.Adverts == null)
            {
                return NotFound();
            }
            var advert = await _context.Adverts.FindAsync(id);
            if (advert == null)
            {
                return NotFound();
            }

            var appartment = _context.Appartments.Find(advert.AppartmentId);
            appartment.Advert = null;
            appartment.AdvertId = null;
            _context.Update(appartment);
            _context.Adverts.Remove(advert);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AdvertExists(Guid id)
        {
            return (_context.Adverts?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
