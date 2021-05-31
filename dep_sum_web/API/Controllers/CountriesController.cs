using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{   

    [ApiController]
    [Route("api/[controller]")]
    public class CountriesController : ControllerBase
    {
        
        private readonly DataContext _context;
        
        public CountriesController(DataContext context){
            _context = context;
        }

        [HttpGet]

        public async Task<ActionResult<IEnumerable<AppCountry>>> GetCountries(){

            return await _context.Countries.ToListAsync();
         
            
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<AppCountry>> GetCountry(int id){
            return await  _context.Countries.FindAsync(id);
        }






    }
}