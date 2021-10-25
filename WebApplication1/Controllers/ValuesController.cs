using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookstoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]

        public IEnumerable<string> Get()
        {
            return new string[] { "Values1", "Values2", "Values3", "Values4" };
        }

        [HttpGet("{id}")]

        public string Get(int id)
        {
            return "The value is ";
        }
    }
}
