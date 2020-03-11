using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Encrypt.Pass;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using PhotoWala.BLL;
using PhotoWala.Helper;
using PhotoWala.Interface;
using PhotoWala.Interface.IService;
using PhotoWala.Models;
using PhotoWala.Security;

namespace PhotoWala.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        //StringBuilder validation = new StringBuilder();
        private IUnitOfWork _unitOfWork;
        private readonly IGenericService<User> _service;
        private readonly IUserRepository _userRepository;
        private readonly ApplicationSettings _appSettings;
        
        //Result result;

        public UserController(IUnitOfWork unitOfWork, IGenericService<User> service, IUserRepository userRepository, IOptions<ApplicationSettings> appSettings)
        {
            _unitOfWork = unitOfWork;
            _service = service;
            _userRepository = userRepository;
            _appSettings = appSettings.Value;

            //result = new Result();
        }

        // GET: api/user/users
        [HttpGet]
        //[Authorize]
        //[Authorize(Roles = Role.Admin)]
        [Authorize(Roles = "User, Admin")]
        [Route("users")]
        public async Task<IActionResult> GetUsers()
        {
            var list = _service.GetAll();
            return Ok(list);
        }

        // POST: api/user/register
        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register(User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                try
                {
                    user.Password = Crypto.Hash(user.Password);
                    _service.Insert(user);
                    _unitOfWork.Commit();

                    return Ok();
                }
                catch (Exception ex)
                {
                    _unitOfWork.Rollback();
                    return BadRequest(ex.Message.ToString());
                }
            }
        }

        [HttpPost]
        [Route("login")]
        //POST : /api/user/Login
        public async Task<IActionResult> Login(Login model)
        {
            var user = _userRepository.Login(model.UserName, model.Password);
            if (user != "false")
            {
                var token = Token(model.UserName, user);
                return Ok(new { token });
            }
            else
            {
                return BadRequest(new { message = "Username or password is incorrect." });
            }
        }

        public string Token(string userName, string role)
        {
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim(ClaimTypes.Name, userName.ToString()),
                        new Claim(ClaimTypes.Role, role)
                    }),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_appSettings.JWT_Secret)), SecurityAlgorithms.HmacSha256Signature)
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var securityToken = tokenHandler.CreateToken(tokenDescriptor);
            var token = tokenHandler.WriteToken(securityToken);

            return token;
        }
    }
}