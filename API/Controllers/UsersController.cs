using API.Data;
using API.entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers{
    
    [ApiController]
    [Route("[controller]")]
   public class UsersController : ControllerBase
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<AppUser>> GetUsers(){
            var users = _context.Users.ToList();

            return users;
        }

         [HttpGet("{id}")]
        public ActionResult<AppUser> GetUsers(int id){
            var users = _context.Users.Find(id);

            return users;
        }
    }
}