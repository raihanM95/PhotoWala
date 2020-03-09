using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoWala.Interface.IService
{
    public interface IUserRepository
    {
        bool Login(string userName, string password);
    }
}
