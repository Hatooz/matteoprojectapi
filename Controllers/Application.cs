using MatteoRbProject.Context;
using MatteoRbProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MatteoRbProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationController : ControllerBase
    {
        private MatteoRbProjectContext _context;

        public ApplicationController(MatteoRbProjectContext context) 
        {
            _context = context;                
        }

        [HttpGet]
        public async Task<IActionResult> GetAllApplications()
        {
            return Ok(await _context.Applications.ToListAsync());
        }


        [HttpGet("byAppartmentId")]
        public async Task<IActionResult> GetApplicationsByAppartmentId([FromQuery] Guid appartmentId) 
        {
            var applications = await _context.Applications.Where(appl => appl.AppartmentId == appartmentId).ToListAsync();
            return Ok(applications);
        }

        [HttpPost]
        public async Task<IActionResult> AddApplication([FromBody] CreateApplicationDTO applicationDTO)
        {
            var application = new Application()
            {
                UserId = applicationDTO.UserId,
                AppartmentId = applicationDTO.AppartmentId,
                User = _context.Users.Find(applicationDTO.UserId),
                Appartment = _context.Appartments.Find(applicationDTO.AppartmentId)
            };

            _context.Applications.Add(application);
            await _context.SaveChangesAsync();
            return Ok(application);
        }
    }
}
