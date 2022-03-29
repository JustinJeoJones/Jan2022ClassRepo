using AspAngularExample.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspAngularExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElectronicController : ControllerBase
    {


        List<Electronic> inventory = new List<Electronic>()
        {
            new Electronic()
            {
                Name = "Alienware",
                Category = "PC",
                Price = 1500
            },
            new Electronic()
            {
                Name= "Dell",
                Category = "PC",
                Price = 300
            },
            new Electronic(){
                Name="LG",
                Category = "TV",
                Price = 500
            }
        };

        [HttpGet("getAll")]
        public List<Electronic> getAll()
        {
            return inventory;
        }

        [HttpGet("GetByName")]
        public Electronic getByName(string name)
        {
            return inventory.Find(e => e.Name == name);
        }

    }
}
