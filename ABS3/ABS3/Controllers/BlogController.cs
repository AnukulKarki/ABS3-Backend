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
            var userId = User.Claims.FirstOrDefault(claim => claim.Type == "UserId")?.Value;
            var userName = User.Claims.FirstOrDefault(claim => claim.Type == "UserName")?.Value;

            return "Authenticated with JWt" +userId;
        }

        [HttpGet]
        [Route("GetDetails")]
        public string GetBlogsId()
        {
            return "Get Id";
        }
    }
}
