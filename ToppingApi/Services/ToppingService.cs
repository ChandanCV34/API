using Apipizza.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Apipizza.Services
{
    public class ToppingService
    {
        private readonly pizzaContext _pizzaContext;

        public ToppingService(pizzaContext context)
        {
            _pizzaContext = context;
        }
       
    
    public Topping GetTopping(int id)
        {
            try
            {
               Topping topping = _pizzaContext.Toppings.Where(t => t.ToppingNumber == id).FirstOrDefault();
                return topping;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }
        public List<Topping> GetToppings()
        {
            try
            {
               List<Topping> toppings = _pizzaContext.Toppings.ToList();
                return toppings;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        public Topping Add(Topping order)
        {

            _pizzaContext.Toppings.Add(order);

            _pizzaContext.SaveChanges();
            return order;
        }
    }
}
