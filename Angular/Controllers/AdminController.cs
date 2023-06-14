using Angular.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Angular.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly WorkoutContext _context;

        public AdminController(WorkoutContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Admin>>> GetAdmins()
        {
            var Admin = await _context.Admin.ToListAsync();
            var GetStaff = Admin.Select(s => new Admin
            {
                AdminId = s.AdminId,
                AdminName = s.AdminName,
                AdminPassword = s.AdminPassword,
            }).ToList();
            return Admin;
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("{id}")]
        public async Task<ActionResult<Admin>> GetAdmin(int id)
        {
            if (_context.Admin == null)
            {
                return NotFound();
            }
            var Admin = await _context.Admin.FindAsync(id);

            if (Admin == null)
            {
                return NotFound();
            }

            return Admin;
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdmin(int id, Admin Admin)
        {
            if (id != Admin.AdminId)
            {
                return BadRequest();
            }

            _context.Entry(Admin).State = EntityState.Modified;


            await _context.SaveChangesAsync();


            return NoContent();
        }


        [HttpPost]
        public async Task<ActionResult<Admin>> PostStaff(Admin Admin)
        {
            if (_context.Admin == null)
            {
                return Problem("Entity set 'HotelContext.Admin'  is null.");
            }
            _context.Admin.Add(Admin);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStaff", new { id = Admin.AdminId }, Admin);
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAdmin(int id)
        {
            if (_context.Admin == null)
            {
                return NotFound();
            }
            var Admin = await _context.Admin.FindAsync(id);
            if (Admin == null)
            {
                return NotFound();
            }

            _context.Admin.Remove(Admin);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}
