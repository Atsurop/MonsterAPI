using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MonsterAPI.Data;
using MonsterAPI.Entities;
using MonsterAPI.Entities.DTO;

namespace MonsterAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationDbContext db;
        private readonly IMapper mapper;

        public UsersController(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UsersListDTO>>> GetUsers()
        {
            var users = await db.Users.ToListAsync();
            return mapper.Map<List<UsersListDTO>>(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            return await db.Users.FindAsync(id);

        }
    }
}