using Microsoft.AspNetCore.Mvc;
using OrderDetailsAPI.Models;
using OrderDetailsAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrderDetailsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        private  readonly OrderDetailsService _orderservice;

        public OrderDetailsController(OrderDetailsService orderDetailsService)
        {
            _orderservice = orderDetailsService;
        }
        // GET: api/<OrderDetailsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<OrderDetailsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<OrderDetailsController>
        [HttpPost]
        public async Task<ActionResult<OrderDetails>> Post([FromBody] OrderDetails order)
        {
            var ord = _orderservice.Add(order);
            if (ord != null)
                return ord;
            return BadRequest("Not able to order");

        }


        // PUT api/<OrderDetailsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OrderDetailsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
