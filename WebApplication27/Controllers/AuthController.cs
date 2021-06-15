using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication27.Models;

namespace WebApplication27.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IJwtAuthManager jwtAuthManager;
        public AuthController(IJwtAuthManager jwtAuthManager)
        {
            this.jwtAuthManager = jwtAuthManager;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("authenticate")]
        public IActionResult Authenticate(UserCred userCred)
        {
            var token = jwtAuthManager.Authenticate(userCred.Username, userCred.Password);
            if (token == null)
                return Unauthorized();
            return Ok(token);
        }
    }
}
