using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System.Reflection;

namespace first_project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostController : Controller
    {
        [HttpGet]
        public ActionResult<List<Post>> GetPosts()
        {
            var posts = new List<Post>
            {
                new() { id = 1, UserId = 1, Title = "Post 1", Body = "Eerste post"},
                new() { id = 2, UserId = 2, Title = "Post 2", Body = "Tweede post"},
            };

            return posts;
        }

        [HttpGet]
        public ActionResult<List<Post>> AddPosts()
        {
            var posts = new List<Post>
            {
                new() { id = 1, UserId = 1, Title = "Post 1", Body = "Eerste post"},
                new() { id = 2, UserId = 2, Title = "Post 2", Body = "Tweede post"},
            };

            return posts;
        }
    }
}
