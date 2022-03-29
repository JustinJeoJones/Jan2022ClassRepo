using AspAngularExample.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspAngularExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoffeeController : ControllerBase
    {
        public List<Coffee> coffees = new List<Coffee>()
        {
            new Coffee()
            {
                Id = 1,
                Name = "Black Coffee",
                Flavor = "Bad",
                Shots =1
            },
            new Coffee()
            {
                Id=2,
                Name = "Peppermint Mocha",
                Flavor ="Peppermint",
                Shots =2
            },
            new Coffee()
            {
                Id = 3,
                Name = "Caramel Ribbon Crunch",
                Flavor ="Caramel",
                Shots = 2
            }
        };

        [HttpGet("GetAll")]
        public List<Coffee> getAll()
        {
            return coffees;
        }

        [HttpGet("GetById")]
        public Coffee getById(int id)
        {
            return coffees.Find(c => c.Id == id);
        }

        [HttpGet("GetByShots")]
        public List<Coffee> getByShots(int shots)
        {
            return coffees.Where(c => c.Shots == shots).ToList();
        }


    }
}
