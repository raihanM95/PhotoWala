using Encrypt.Pass;
using PhotoWala.DatabaseContext.DatabaseContext;
using PhotoWala.Interface.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhotoWala.Service.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly PhotoWalaDbContext _db;
        
        public UserRepository(PhotoWalaDbContext db)
        {
            _db = db;
        }

        public string Login(string userName, string password)
        {
            var user = _db.Users.Where(u => u.UserName == userName).SingleOrDefault();
            if(user != null)
            {
                if (string.Compare(Crypto.Hash(password), user.Password) == 0)
                {
                    return user.Role;
                }
            }
            
            return "false";
        }
    }
}
