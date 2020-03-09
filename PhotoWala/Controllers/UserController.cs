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
        //StringBuilder validation = new StringBuilder();
        private readonly IGenericService<User> _service;
        
        //Result result;

        public UserController(IGenericService<User> service)
        {
            _service = service;
            
            //result = new Result();
        }

        // GET: api/user/users
        [HttpGet]
        [Route("users")]
        public async Task<IActionResult> GetUsers()
        {
            var list = _service.GetAll();
            return Ok(list);
        }

        // POST: api/user/register
        [HttpPost]
        [Route("register")]
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
                    _service.Insert(user);
                    _service.Save();

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