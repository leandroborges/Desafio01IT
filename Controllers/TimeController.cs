using Desafio01IT.Model;
using Microsoft.AspNetCore.Mvc;

namespace Desafio01IT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeController : ControllerBase
    {
        private readonly ILogger<TimeController> _logger;

        public TimeController(ILogger<TimeController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
        
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpGet()]
        public IEnumerable<Time> List()
        {
            return null;
        }
    }
}
