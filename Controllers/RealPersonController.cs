using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Economy.Models;

namespace Economy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RealPersonController : ControllerBase
    {
        private  Economy_Context db=new Economy_Context();


        // GET: api/RealPerson
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RealPerson>>> GetRealPersons()
        {
            return await db.RealPersons.ToListAsync();
        }

        // GET: api/RealPerson/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RealPerson>> GetRealPerson(int id)
        {
            var realPerson = await db.RealPersons.FindAsync(id);

            if (realPerson == null)
            {
                return NotFound();
            }

            return realPerson;
        }

        // PUT: api/RealPerson/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRealPerson(int id, RealPerson realPerson)
        {
            if (id != realPerson.realPersonID)
            {
                return BadRequest();
            }

            db.Entry(realPerson).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RealPersonExists(id))
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

        // POST: api/RealPerson
        [HttpPost]
        public async Task<ActionResult<RealPerson>> PostRealPerson(RealPerson realPerson)
        {
            db.RealPersons.Add(realPerson);
            await db.SaveChangesAsync();

            return CreatedAtAction("GetRealPerson", new { id = realPerson.realPersonID }, realPerson);
        }

        // DELETE: api/RealPerson/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<RealPerson>> DeleteRealPerson(int id)
        {
            var realPerson = await db.RealPersons.FindAsync(id);
            if (realPerson == null)
            {
                return NotFound();
            }

            db.RealPersons.Remove(realPerson);
            await db.SaveChangesAsync();

            return realPerson;
        }

        private bool RealPersonExists(int id)
        {
            return db.RealPersons.Any(e => e.realPersonID == id);
        }
    }
}
