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
    public class OrderController : ControllerBase
    {
        private  readonly UserService _userService;

        public OrderController(UserService userService)
        {
            _userService = userService;
        }
        // GET: api/<OrderController>
        [HttpGet]
        public IEnumerable<OrderDTO> Get()
        {
            return null;
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public void Get(OrderDTO orderDTO)
        {
           _userService.Orders(orderDTO);
            
           
        }

        // POST api/<OrderController>
        [HttpPost]
        public void Post([FromBody] OrderDTO orderDTO)
        {
            _userService.Orders(orderDTO);
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
