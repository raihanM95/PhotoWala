using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PhotoWala.BLL;
using PhotoWala.Helper;
using PhotoWala.Interface;
using PhotoWala.Models;

namespace PhotoWala.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        StringBuilder validation = new StringBuilder();
        private readonly UserManager _manager;
        //Result result;

        public UserController(UserManager manager)
        {
            _manager = manager;
            //result = new Result();
        }

        // GET: api/User/users
        [HttpGet]
        [Route("users")]
        public async Task<IActionResult> GetUsers()
        {
            var list = _manager.GetUsers();
            return Ok(list);
        }

        // POST: api/User/register
        [HttpPost]
        //[Route("register")]
        public IActionResult Register(User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                try
                {
                    _manager.Register(user);
                    return Ok();
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message.ToString());
                }
            }
        }
    }
}