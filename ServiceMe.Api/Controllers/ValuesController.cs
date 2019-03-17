using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Interfaces;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;

namespace BuildHomeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        ISampleBusiness sb;
        private readonly BuildHomeDBContext _context;

        public ValuesController(ISampleBusiness sampleBusiness, BuildHomeDBContext buildHomeDBContext)
        {
            sb = sampleBusiness;
            _context = buildHomeDBContext;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            sb.TestBusinessMethod("s",_context);
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(string id)
        {
            return new BusinessLayer.BusinessClass().layerTest(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
