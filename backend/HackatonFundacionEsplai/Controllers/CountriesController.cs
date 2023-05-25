using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HackatonFundacionEsplai.Context;
using HackatonFundacionEsplai.Entities;

namespace HackatonFundacionEsplai.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public CountriesController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: api/Usuarios/CheckCredentials/email_ejemplo@ejemplo.com,psswrd_ejemplo
        [HttpGet("CheckCredentials/name_{name},psswrd_{psswrd}")]
        public async Task<ActionResult<bool>> CheckCredentials(string name, string psswrd)
        {
            if (_context.Countries == null)
            {
                return NotFound();
            }

            if (CountryExists(name))
            {
                var country = _context.Countries.Find(name);

                if (country.Password == psswrd)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        // GET: api/Usuarios/EmailExist/ejemplo@ejemplo.com
        [HttpGet("NameExist/{id}")]
        public async Task<ActionResult<bool>> CheckEmailRegistered(string id)
        {
            if (_context.Countries == null)
            {
                return NotFound();
            }

            return CountryExists(id);
        }


        // GET: api/Countries
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Country>>> GetCountries()
        {
          if (_context.Countries == null)
          {
              return NotFound();
          }
            return await _context.Countries.ToListAsync();
        }

        // GET: api/Countries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Country>> GetCountry(string id)
        {
          if (_context.Countries == null)
          {
              return NotFound();
          }
            var country = await _context.Countries.FindAsync(id);

            if (country == null)
            {
                return NotFound();
            }

            return country;
        }

        // PUT: api/Countries/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCountry(string id, Country country)
        {
            if (id != country.Name)
            {
                return BadRequest();
            }

            _context.Entry(country).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CountryExists(id))
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

        // POST: api/Countries
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Country>> PostCountry(Country country)
        {
          if (_context.Countries == null)
          {
              return Problem("Entity set 'ApplicationDBContext.Countries'  is null.");
          }
            _context.Countries.Add(country);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CountryExists(country.Name))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCountry", new { id = country.Name }, country);
        }

        // DELETE: api/Countries/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCountry(string id)
        {
            if (_context.Countries == null)
            {
                return NotFound();
            }
            var country = await _context.Countries.FindAsync(id);
            if (country == null)
            {
                return NotFound();
            }

            _context.Countries.Remove(country);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CountryExists(string id)
        {
            return (_context.Countries?.Any(e => e.Name == id)).GetValueOrDefault();
        }
    }
}
