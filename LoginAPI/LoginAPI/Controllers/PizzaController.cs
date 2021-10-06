using LoginAPI.Models;
using LoginAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LoginAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PizzaController : ControllerBase
    {
        private readonly UserService _userService;

        public PizzaController(UserService userService)
        {
            _userService = userService;
        }
        // GET: api/<PizzaController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PizzaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PizzaController>
        [HttpPost]
        public void Post([FromBody] PizzaDTO pizzaDTO)
        {
            _userService.PizzaDetail(pizzaDTO);


        }

        // PUT api/<PizzaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PizzaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
