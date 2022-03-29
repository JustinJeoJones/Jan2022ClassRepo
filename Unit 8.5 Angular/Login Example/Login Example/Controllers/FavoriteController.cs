using Login_Example.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Login_Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavoriteController : ControllerBase
    {
        public loginDemoContext loginDemoContext = new loginDemoContext();
        [HttpPost("Add")]
        public Favorite AddFavorite(int uId, string myText)
        {
            Favorite newFavorite = new Favorite()
            {
                UserId = uId,
                MyText = myText
            };
            loginDemoContext.Favorites.Add(newFavorite);
            loginDemoContext.SaveChanges();
            return newFavorite;
        }

        [HttpGet("Get")]
        public List<Favorite> GetFavorites(int uId)
        {
            return loginDemoContext.Favorites.Where(f => f.UserId == uId).ToList();
        }
    }
}
