using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiController.Models;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private readonly FavoriteFoodsContext _context;

        public ApiController(FavoriteFoodsContext context)
        {
            _context = context;
        }

        // GET: api/Api
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Food>>> GetFavoriteFoods()
        {
            return await _context.FavoriteFoods.ToListAsync();
        }

        // GET: api/Api/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Food>> GetFood(long id)
        {
            var food = await _context.FavoriteFoods.FindAsync(id);

            if (food == null)
            {
                return NotFound();
            }

            return food;
        }

        // PUT: api/Api/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFood(long id, Food food)
        {
            if (id != food.Id)
            {
                return BadRequest();
            }

            _context.Entry(food).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FoodExists(id))
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

        // POST: api/Api
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Food>> PostFood(Food food)
        {
            _context.FavoriteFoods.Add(food);
            await _context.SaveChangesAsync();

            // return CreatedAtAction("GetFood", new { id = food.Id }, food);
            return CreatedAtAction("GetFood", new { id = food.Id}, food);
        }

        // DELETE: api/Api/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFood(long id)
        {
            var food = await _context.FavoriteFoods.FindAsync(id);
            if (food == null)
            {
                return NotFound();
            }

            _context.FavoriteFoods.Remove(food);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FoodExists(long id)
        {
            return _context.FavoriteFoods.Any(e => e.Id == id);
        }
    }
}
