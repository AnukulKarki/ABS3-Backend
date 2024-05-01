using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ABS3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        [Route("GetData")]
        public string GetBlogs()
        {
            return "Authenticated with JWt";
        }

        [HttpGet]
        [Route("GetDetails")]
        public string GetBlogsId()
        {
            return "Get Id";
        }
    }
}
