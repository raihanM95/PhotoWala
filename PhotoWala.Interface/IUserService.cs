using PhotoWala.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoWala.Interface
{
    public interface IUserService
    {
        bool Register(User user);
        bool Login(string userName, string password);
        //
        bool UpdateInfo(User user);
        List<User> GetUsers();
        User GetByID(int id);
        bool DeleteUser(int id);
    }
}
