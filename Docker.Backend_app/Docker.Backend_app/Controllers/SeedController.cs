using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Docker.Backend_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeedController : ControllerBase
    {
        private readonly KibongaDbContext context;

        public SeedController(KibongaDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Seed()
        {
            User[] users = new User[10];
            string[] names = new[] { "Pavle", "Kibonga", "Kimur", "John", "Mike", "Liver King", "Danni", "Joel", "Grizzly" };
            string[] jobs = new[] { "Software Engineer", "Product Manager", "Team Lead", "Quality Assurance", "CEO" };
            Random rnd = new Random();
            for(int i= 0; i < 10; i++)
            {
                users[i] = new User
                {
                    Name = names[rnd.Next(names.Length)],
                    Age = (byte)rnd.Next(18, 35),
                    Job = jobs[rnd.Next(jobs.Length)]
                };
            }
            context.Users.AddRange(users);
            context.SaveChanges();
            return Ok(); 
        }
    }
}
