using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JETech.JEDayCare.Core.Administration.Interfaces;
using JETech.JEDayCare.Core.Data.Entities;
using JETech.NetCoreWeb.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JETech.JEDayCare.Web.Controllers.Api.Administration
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminGeneralApiController : ControllerBase
    {        
        private readonly IGeneralService _generalService;

        public AdminGeneralApiController(IGeneralService  generalService)
        {
            _generalService = generalService;
        }

        // GET: api/<AdminGenApiController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<AdminGenApiController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AdminGenApiController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AdminGenApiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AdminGenApiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpGet("States")]
        public async Task<IActionResult> States(string codeContry)
        {
            try
            {
                var result = _generalService.GetStates(new NetCoreWeb.Types.ActionQueryArgs<State>()).Data;

                if (!string.IsNullOrEmpty(codeContry)) result.Where(c => c.Contry.Code == codeContry);

                return Ok(await result.ToListAsync());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, JETechException.Parse(ex).AppMessage);
            }        
        }
    }
}
