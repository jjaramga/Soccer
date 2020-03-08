using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Soccer.Web.Data;
using Soccer.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Soccer.web.Controllers.API
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class TournamentsController: ControllerBase

    {
        private readonly DataContext _context;

        public TournamentsController(DataContext dataContext)
        {
            _context = dataContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetTournaments()
        {
            List<TournamentEntity> tournaments = await _context.Tournaments.Include(t=>t.Groups).ToListAsync();
             return Ok(tournaments);
        }

    }
}
