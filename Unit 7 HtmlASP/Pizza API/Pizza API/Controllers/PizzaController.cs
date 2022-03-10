using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pizza_API.Models;

namespace Pizza_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        //return all pizzas
        //api/Pizza
        [HttpGet()]
        public List<Pizza> GetAllPizzas()
        {
            List<Pizza> result = null;

            using(PizzaDBContext context = new PizzaDBContext())
            {
                result = context.Pizzas.ToList();
            }

            return result;
        }

        //Returns pizza by id
        //api/Pizza/{id}
        //api/Pizza/1    api/Pizza/5
        [HttpGet("{id}")]
        public Pizza GetPizzaById(int id)
        {
            Pizza result = null;

            using(PizzaDBContext context = new PizzaDBContext())
            {
                result = context.Pizzas.FirstOrDefault(p => p.Id == id);
                //result = context.Pizzas.Find(id);
            }

            return result;
        }


        //Returns the first matching pizza by name
        //api/Pizza/SearchByName?name=pepperoni
        [HttpGet("SearchByName")]
        public Pizza GetPizzaByName(string name)
        {
            Pizza result = null;

            using(PizzaDBContext context = new PizzaDBContext())
            {
                //result = context.Pizzas.FirstOrDefault(p => p.Name.ToLower().Trim() == name.ToLower().Trim());
                result = context.Pizzas.FirstOrDefault(p => p.Name.Contains(name));
            }

            return result;
        }

        //Add a new pizza to the DB
        //api/Pizza/Add?name=Cheese&price=5.0&description=Pizza with Just cheese
        [HttpPost("Add")]
        public Pizza AddPizza(string name, double price, string description)
        {
            Pizza newPizza = new Pizza()
            {
                Name = name,
                Price = price,
                Description = description
            };

            using (PizzaDBContext context = new PizzaDBContext()) 
            {
                context.Pizzas.Add(newPizza);
                context.SaveChanges();
            }

            return newPizza;
        }

        //delete pizza from db by id
        //api/pizza/delete/{id}
        //api/pizza/delete/4
        [HttpDelete("delete/{id}")]
        public Pizza DeletePizza(int id)
        {
            Pizza result = null;

            using(PizzaDBContext context = new PizzaDBContext())
            {
                result = context.Pizzas.FirstOrDefault(p => p.Id == id);
                context.Pizzas.Remove(result);
                context.SaveChanges();
            }

            return result;
        }

        //api/pizza/ChangePrice/3?price=6.50
        [HttpPut("ChangePrice/{id}")]
        public Pizza ChangePizzaPrice(int id, double price)
        {
            Pizza result = null;

            using(PizzaDBContext context = new PizzaDBContext())
            {
                result = context.Pizzas.FirstOrDefault(p => p.Id == id);
                result.Price = price;
                context.Pizzas.Update(result);
                context.SaveChanges();
            }

            return result;
        }
    }
}
