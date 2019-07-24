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
    public class ActivityTypeController : ControllerBase
    {
        private  Economy_Context db=new Economy_Context();


        // GET: api/ActivityType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ActivityType>>> GetActivityTypes()
        {
            return await db.ActivityTypes.ToListAsync();
        }

        // GET: api/ActivityType/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ActivityType>> GetActivityType(int id)
        {
            var activityType = await db.ActivityTypes.FindAsync(id);

            if (activityType == null)
            {
                return NotFound();
            }

            return activityType;
        }

        // PUT: api/ActivityType/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutActivityType(int id, ActivityType activityType)
        {
            if (id != activityType.activtyTypeID)
            {
                return BadRequest();
            }

            db.Entry(activityType).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ActivityTypeExists(id))
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

        // POST: api/ActivityType
        [HttpPost]
        public async Task<ActionResult<ActivityType>> PostActivityType(ActivityType activityType)
        {
            db.ActivityTypes.Add(activityType);
            await db.SaveChangesAsync();

            return CreatedAtAction("GetActivityType", new { id = activityType.activtyTypeID }, activityType);
        }

        // DELETE: api/ActivityType/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ActivityType>> DeleteActivityType(int id)
        {
            var activityType = await db.ActivityTypes.FindAsync(id);
            if (activityType == null)
            {
                return NotFound();
            }

            db.ActivityTypes.Remove(activityType);
            await db.SaveChangesAsync();

            return activityType;
        }

        private bool ActivityTypeExists(int id)
        {
            return db.ActivityTypes.Any(e => e.activtyTypeID == id);
        }
    }
}
