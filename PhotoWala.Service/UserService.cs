using PhotoWala.DAL.Repositories;
using PhotoWala.Interface;
using PhotoWala.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoWala.Service
{
    public class UserService : IUserService
    {
        private readonly UserRepository _repository;

        public UserService(UserRepository repository)
        {
            _repository = repository;
        }
        public bool Register(User user)
        {
            return _repository.Register(user);
        }
        public bool Login(string userName, string password)
        {
            return _repository.Login(userName, password);
        }
        //
        public bool UpdateInfo(User user)
        {
            return _repository.UpdateInfo(user);
        }
        public List<User> GetUsers()
        {
            return _repository.GetUsers();
        }
        public User GetByID(int id)
        {
            return _repository.GetByID(id);
        }
        public bool DeleteUser(int id)
        {
            return _repository.DeleteUser(id);
        }
    }
}
