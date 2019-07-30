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
    public class AssetController : ControllerBase
    {
        private  Economy_Context db=new Economy_Context();

        // GET: api/Asset
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Asset>>> GetAssets()
        {
            return await db.Assets.ToListAsync();
        }

        // GET: api/Asset/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Asset>> GetAsset(int id)
        {
            var asset = await db.Assets.FindAsync(id);

            if (asset == null)
            {
                return NotFound();
            }

            return asset;
        }

        // PUT: api/Asset/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsset(int id, Asset asset)
        {
            if (id != asset.AssetID)
            {
                return BadRequest();
            }

            db.Entry(asset).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AssetExists(id))
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

        // POST: api/Asset
        [HttpPost]
        public async Task<ActionResult<Asset>> PostAsset(Asset asset)
        {
            db.Assets.Add(asset);
            await db.SaveChangesAsync();

            return CreatedAtAction("GetAsset", new { id = asset.AssetID }, asset);
        }

        // DELETE: api/Asset/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Asset>> DeleteAsset(int id)
        {
            var asset = await db.Assets.FindAsync(id);
            if (asset == null)
            {
                return NotFound();
            }

            db.Assets.Remove(asset);
            await db.SaveChangesAsync();

            return asset;
        }

        private bool AssetExists(int id)
        {
            return db.Assets.Any(e => e.AssetID == id);
        }
    }
}
