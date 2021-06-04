using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SimpleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "dotnet", "paybook" };
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "Mahesh Bhat";
        }

        
    }
}
