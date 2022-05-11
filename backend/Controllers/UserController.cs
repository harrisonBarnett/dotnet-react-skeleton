using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // EXAMPLE DATA
        private static readonly string[] data = new[]
{
        "qewrty", "blambp", "snacks", "draughty", "laudnem", "probably", "sickoy", "drughh", "incskl", "fdsafdas"
        };

        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            User[] users = new User[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                User tmp = new User();
                tmp.Id = i;
                tmp.Name = data[i];
                users[i] = tmp;
            }
            return users;
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
