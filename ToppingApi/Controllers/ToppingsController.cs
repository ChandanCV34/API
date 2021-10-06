using Apipizza.Models;
using Apipizza.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Apipizza.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToppingsController : ControllerBase
    {
        private readonly ToppingService _toppingService;

        public ToppingsController(ToppingService service)
        {
            _toppingService = service;
        }
        // GET: api/Toppings1
        [HttpGet]
        public IEnumerable<Topping> GetToppings()
        {
            return _toppingService.GetToppings();
        }

        // GET: api/Toppings1/5
        [HttpGet("{id}")]
        public Topping GetTopping(int id)
        {
            var topping = _toppingService.GetTopping(id);

            if (topping == null)
            {
                return null;
            }

            return topping;
        }
        [HttpPost]
        public async Task<ActionResult<Topping>> Post([FromBody] Topping toping)
        {
            var tops = _toppingService.Add(toping);
            if (tops != null)
                return tops;
            return BadRequest("Not able to order");


        }





    }
}
