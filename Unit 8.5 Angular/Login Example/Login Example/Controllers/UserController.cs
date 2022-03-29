using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Login_Example.models;

namespace Login_Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public loginDemoContext loginDemoContext = new loginDemoContext();
        
        [HttpGet("login")]
        public User login(string username, string password)
        {
            return loginDemoContext.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
        }

        [HttpPost("add")]
        public User AddUser(string username, string password)
        {
            User newUser = new User { Username = username, Password = password };
            loginDemoContext.Users.Add(newUser);
            loginDemoContext.SaveChanges();
            return newUser;
        }
    }
}
