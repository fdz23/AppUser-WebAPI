using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AppUser.Data;
using AppUser.Domain;

namespace AppUser.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalaController : ControllerBase
    {
        private readonly IRepository<Sala> _context;

        public SalaController(IRepository<Sala> context)
        {
            _context = context;
        }

        // GET: api/Sala
        [HttpGet]
        public async Task<IEnumerable<Sala>> GetSala()
        {
            return await _context.ResearchAll();
        }

        // GET: api/Sala/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Sala>> GetSala(Guid id)
        {
            var sala = await _context.ResearchID(id);

            if (sala == null)
            {
                return NotFound();
            }

            return sala;
        }

        // PUT: api/Sala/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSala(Guid id, Sala sala)
        {
            if (id != sala.Id)
            {
                return BadRequest();
            }

            await _context.Update(sala);

            return NoContent();
        }

        // POST: api/Sala
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Sala>> PostSala(Sala sala)
        {
           await _context.Create(sala);

            return CreatedAtAction("GetSala", new { id = sala.Id }, sala);
        }

        // DELETE: api/Sala/5
        [HttpDelete("{id}")]
        public async Task<bool> DeleteSala(Guid id)
        {
             var sala = await _context.Exists(id);
            if (!sala)
            {
                return sala;
            }

            await _context.Delete(id);

            return sala;
        }

        private Task<bool> SalaExists(Guid id)
        {
            return _context.Delete(id);
        }
    }
}