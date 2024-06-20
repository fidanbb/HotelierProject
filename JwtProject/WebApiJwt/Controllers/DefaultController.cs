using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiJwt.Models;

namespace WebApiJwt.Controllers
{
    [Route("api/[controller]")]
    
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet("[action]")]
        public IActionResult CreateToken()
        {
            return Ok(new TokenGenerator().TokenCreate());
        }

        [HttpGet("[action]")]
        public IActionResult AdminCreateToken()
        {
            return Ok(new TokenGenerator().TokenCreateAdmin());
        }

        [Authorize(AuthenticationSchemes = "Bearer")]
        [HttpGet("[action]")]
        public IActionResult Test2()
        {
            return Ok("Welcome");
        }
        [Authorize(AuthenticationSchemes = "Bearer",Roles = "Admin,Visitor")]
       // [Authorize(Roles = "Admin,Visitor")]
        [HttpGet("[action]")]
        public IActionResult Test3()
        {
            return Ok("Token Login Successfully");
        }
    }
}
