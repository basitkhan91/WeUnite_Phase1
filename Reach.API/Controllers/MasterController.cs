using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reach.Entity;
using Reach.Repository;

namespace Reach.API.Controllers
{
    [Route("api/master")]
    [ApiController]
    public class MasterController : ControllerBase
    {
        public IUnitOfWork UnitOfWork;

        public MasterController(IUnitOfWork _unitOfWork)
        {
            UnitOfWork = _unitOfWork;
        }

        [HttpGet("countries/{id}")]
        public ActionResult<IEnumerable<Country>> GetCountries(int id)
        {
            var countries = UnitOfWork.Repository<Country>().GetAll().ToList();
            return Ok(countries);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
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
