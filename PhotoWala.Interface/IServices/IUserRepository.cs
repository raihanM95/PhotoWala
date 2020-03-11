using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoWala.Interface.IService
{
    public interface IUserRepository
    {
        string Login(string userName, string password);
    }
}
