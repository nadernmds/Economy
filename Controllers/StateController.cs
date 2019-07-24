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
    public class StateController : ControllerBase
    {
        private Economy_Context db = new Economy_Context();


        // GET: api/State
        [HttpGet]
        public async Task<ActionResult<IEnumerable<State>>> GetStates()
        {
            return await db.States.ToListAsync();
        }

        // GET: api/State/5
        [HttpGet("{id}")]
        public async Task<ActionResult<State>> GetState(int id)
        {
            var state = await db.States.FindAsync(id);

            if (state == null)
            {
                return NotFound();
            }

            return state;
        }

        // PUT: api/State/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutState(int id, State state)
        {
            if (id != state.stateID)
            {
                return BadRequest();
            }

            db.Entry(state).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StateExists(id))
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

        // POST: api/State
        [HttpPost]
        public async Task<ActionResult<State>> PostState(State state)
        {
            db.States.Add(state);
            await db.SaveChangesAsync();

            return CreatedAtAction("GetState", new { id = state.stateID }, state);
        }

        // DELETE: api/State/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<State>> DeleteState(int id)
        {
            var state = await db.States.FindAsync(id);
            if (state == null)
            {
                return NotFound();
            }

            db.States.Remove(state);
            await db.SaveChangesAsync();

            return state;
        }

        private bool StateExists(int id)
        {
            return db.States.Any(e => e.stateID == id);
        }
    }
}
