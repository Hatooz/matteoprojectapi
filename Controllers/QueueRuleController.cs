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
    public class QueueRuleController : ControllerBase
    {
        private readonly MatteoRbProjectContext _context;

        public QueueRuleController(MatteoRbProjectContext context)
        {
            _context = context;
        }

        // GET: api/QueueRule
        [HttpGet]
        public async Task<ActionResult<IEnumerable<QueueRule>>> GetQueueRules()
        {
          if (_context.QueueRules == null)
          {
              return NotFound();
          }
            return await _context.QueueRules.ToListAsync();
        }

        // GET: api/QueueRule/5
        [HttpGet("{id}")]
        public async Task<ActionResult<QueueRule>> GetQueueRule(Guid id)
        {
          if (_context.QueueRules == null)
          {
              return NotFound();
          }
            var queueRule = await _context.QueueRules.FindAsync(id);

            if (queueRule == null)
            {
                return NotFound();
            }

            return queueRule;
        }

        // PUT: api/QueueRule/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutQueueRule(Guid id, QueueRule queueRule)
        {
            if (id != queueRule.Id)
            {
                return BadRequest();
            }

            _context.Entry(queueRule).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QueueRuleExists(id))
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

        // POST: api/QueueRule
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<QueueRule>> PostQueueRule(QueueRule queueRule)
        {
          if (_context.QueueRules == null)
          {
              return Problem("Entity set 'MatteoRbProjectContext.QueueRules'  is null.");
          }
            _context.QueueRules.Add(queueRule);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetQueueRule", new { id = queueRule.Id }, queueRule);
        }

        // DELETE: api/QueueRule/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteQueueRule(Guid id)
        {
            if (_context.QueueRules == null)
            {
                return NotFound();
            }
            var queueRule = await _context.QueueRules.FindAsync(id);
            if (queueRule == null)
            {
                return NotFound();
            }

            _context.QueueRules.Remove(queueRule);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool QueueRuleExists(Guid id)
        {
            return (_context.QueueRules?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
