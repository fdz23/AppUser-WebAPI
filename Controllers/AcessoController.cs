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
    public class AcessoController : ControllerBase
    {
        private readonly IRepository<Acesso> _context;

        public AcessoController(IRepository<Acesso> context)
        {
            _context = context;
        }

        // GET: api/Acesso
        [HttpGet]
        public async Task<IEnumerable<Acesso>> GetAcesso()
        {
            return await _context.ResearchAll();
        }

        // GET: api/Acesso/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Acesso>> GetAcesso(Guid id)
        {
            var acesso = await _context.ResearchID(id);

            if (acesso == null)
            {
                return NotFound();
            }

            return acesso;
        }

        // PUT: api/Acesso/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAcesso(Guid id, Acesso acesso)
        {
            if (id != acesso.Id)
            {
                return BadRequest();
            }

            await _context.Update(acesso);

            return NoContent();
        }

        // POST: api/Acesso
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Acesso>> PostAcesso(Acesso acesso)
        {
            await _context.Create(acesso);

            return CreatedAtAction("GetAcesso", new { id = acesso.Id }, acesso);
        }

        // DELETE: api/Acesso/5
        [HttpDelete("{id}")]
        public async Task<bool> DeleteAcesso(Guid id)
        {
            var acesso = await _context.Exists(id);
            if (!acesso)
            {
                return acesso;
            }

            await _context.Delete(id);

            return acesso;
        }

        private Task<bool> AcessoExists(Guid id)
        {
            return _context.Exists(id);
        }
    }
}