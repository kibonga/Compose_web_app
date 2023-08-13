using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace Docker.Backend_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly KibongaDbContext context;

        public UsersController(KibongaDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<User> users = context.Users.ToList();
            return Ok(users);
        }

        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            context.Users.Add(user); 
            context.SaveChanges();
            return Ok();
        }
    }
}
