using PhotoWala.Interface.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhotoWala.Service.Repositories
{
    public class UserRepository : IUserRepository
    {
        public bool Login(string userName, string password)
        {
            int isExecuted = 0;

            if (isExecuted > 0)
            {
                return true;
            }

            return false;
        }
    }
}
