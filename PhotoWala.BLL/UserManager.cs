using PhotoWala.Interface;
using PhotoWala.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoWala.BLL
{
    public class UserManager
    {
        private readonly IUserService _service;

        public UserManager(IUserService service)
        {
            _service = service;
        }

        public bool Register(User user)
        {
            return _service.Register(user);
        }
        public bool Login(string userName, string password)
        {
            return _service.Login(userName, password);
        }
        //
        public bool UpdateInfo(User user)
        {
            return _service.UpdateInfo(user);
        }
        public List<User> GetUsers()
        {
            return _service.GetUsers();
        }
        public User GetByID(int id)
        {
            return _service.GetByID(id);
        }
        public bool DeleteUser(int id)
        {
            return _service.DeleteUser(id);
        }
    }
}
