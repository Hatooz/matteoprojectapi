using MatteoRbProject.Context;
using MatteoRbProject.ExtentionMethods;
using MatteoRbProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace MatteoRbProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private MatteoRbProjectContext _context;

        public SearchController(MatteoRbProjectContext context) 
        {
            _context = context;
        
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PropertyDTO>>> GetFilteredProperties([FromQuery] SearchFilter filter)
        {
            var searchString = filter.SearchString?.ToLower();
            var noRules = filter.includeRules == false && filter.includeAddress == false && filter.includeObjectNumber == false && filter.includeLmNumber == false && filter.includeHasAdvert == false;

            var ruleSet = filter.includeRules ? _context.Properties.Where(p => EF.Functions.Like(p.QueueRule.Name, String.Format("%{0}", searchString))) : _context.Properties;
            var addressSet = filter.includeAddress ? _context.Properties.Where(p => p.Addresses.Any(a => a.PostalCode.Contains(searchString) || a.Number.ToString() == searchString || a.Street.Contains(searchString) || a.City.Contains(searchString) || a.County.Contains(searchString))) : _context.Properties;
            var advertSert = filter.includeHasAdvert ? _context.Properties.Where(p => p.Appartments.Any(a => a.AdvertId != null)) : _context.Properties;
            var objectNumberSet = filter.includeObjectNumber ? _context.Properties.Where(p => p.ObjectNumber.Contains(searchString)) : _context.Properties;
            var lmNumberSet = filter.includeLmNumber ? _context.Properties.Where(p => p.LMNumber.ToString() == searchString) : _context.Properties;

 

            //var addressSet = addressSearch;
            //var ruleSet = ruleSearch;
            //var advertSert = advertSearch;
            //var objectNumberSet = objectNumberSearch;
            //var lmNumberSet = lmNumberSearch;

            var searchStringNoRules = _context.Properties.Where(
                p => p.Addresses.Any(a => a.PostalCode.Contains(searchString) || a.Number.ToString() == searchString || a.Street.Contains(searchString) || a.City.Contains(searchString) || a.County.Contains(searchString))).
                Union(_context.Properties.Where(p => EF.Functions.Like(p.QueueRule.Name, String.Format("%{0}", searchString)))).                
                Union(_context.Properties.Where(p => p.ObjectNumber.Contains(searchString))).
                Union(_context.Properties.Where(p => p.LMNumber.ToString() == searchString));

            var properties = string.IsNullOrEmpty(searchString) ? await _context.Properties.ToListAsync() : noRules ? await searchStringNoRules.ToListAsync() : await addressSet.Intersect(ruleSet).Intersect(advertSert).Intersect(objectNumberSet).Intersect(lmNumberSet).ToListAsync();


            foreach (var property in properties)
            {
                property.QueueRule = await _context.QueueRules.Where(rule => rule.Id == property.QueueRuleId).FirstAsync();
                property.Appartments = await _context.Appartments.Where(appartment => appartment.PropertyId == property.Id).ToListAsync();
                property.Addresses = await _context.Addresses.Where(address => address.PropertyId == property.Id).ToListAsync();
                _context.Update(property);
            }
            //await _context.SaveChangesAsync();
            var result = properties.Select(p => p.ToDto()).ToList();

            return Ok(result);
        }

        [HttpGet("appartments")]
        public async Task<IActionResult> SearchAppartments([FromQuery] SearchFilter filter)
        {
            var searchString = filter.SearchString?.ToLower() ?? "";
            var noRules = filter.includeRules == false && filter.includeAddress == false && filter.includeObjectNumber == false && filter.includeLmNumber == false && filter.includeHasAdvert == false;

            var ruleSet = filter.includeRules ? _context.Appartments.Where(p => EF.Functions.Like(p.QueueRule.Name, String.Format("%{0}", searchString))) : _context.Appartments;

            var addressSet = filter.includeAddress ? _context.Appartments.Where(a => a.Address.PostalCode.Contains(searchString) || a.Address.Number.ToString() == searchString || a.Address.Street.Contains(searchString) || a.Address.City.Contains(searchString) || a.Address.County.Contains(searchString)) : _context.Appartments;

            var advertSert = filter.includeHasAdvert ? _context.Appartments.Where(a => a.AdvertId != null) : _context.Appartments;
            var objectNumberSet = filter.includeObjectNumber ? _context.Appartments.Where(a => a.ObjectNumber.Contains(searchString)) : _context.Appartments;
            var lmNumberSet = filter.includeLmNumber ? _context.Appartments.Where(a => a.LMNumber.ToString() == searchString) : _context.Appartments;

            var searchStringNoRules = _context.Appartments.Where(
               a => a.Address.PostalCode.Contains(searchString) || a.Address.Number.ToString() == searchString || a.Address.Street.Contains(searchString) || a.Address.City.Contains(searchString) || a.Address.County.Contains(searchString)).
               Union(_context.Appartments.Where(a => EF.Functions.Like(a.QueueRule.Name, String.Format("%{0}", searchString)))).
               Union(_context.Appartments.Where(p => p.ObjectNumber.Contains(searchString))).
               Union(_context.Appartments.Where(p => p.LMNumber.ToString() == searchString));


            var intersection = addressSet.Intersect(ruleSet).Intersect(advertSert).Intersect(objectNumberSet).Intersect(lmNumberSet);

            var appartments = string.IsNullOrEmpty(searchString) ? await _context.Appartments.ToListAsync() : noRules ? await searchStringNoRules.ToListAsync() : await intersection.ToListAsync();



            foreach (var appartment in appartments)
            {

                appartment.Advert = await _context.Adverts.Where(ad => ad.AppartmentId == appartment.Id).FirstOrDefaultAsync();
                appartment.Address = await _context.Addresses.Where(adr => adr.Appartments.Contains(appartment)).FirstOrDefaultAsync();
                appartment.QueueRule = await _context.QueueRules.Where(q => q.Appartments.Contains(appartment)).FirstOrDefaultAsync();
                appartment.Applications = await _context.Applications.Where(appl => appl.AppartmentId == appartment.Id).ToListAsync();
            }


            return Ok(appartments);
        }

        
    }
}
