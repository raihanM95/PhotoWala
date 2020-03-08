using Microsoft.EntityFrameworkCore;
using PhotoWala.DatabaseContext.DatabaseContext;
using PhotoWala.Interface;
using PhotoWala.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhotoWala.Service.Repositories
{
    public class UserRepository : IUserService
    {
        private readonly PhotoWalaDbContext _db;

        public UserRepository(PhotoWalaDbContext db)
        {
            _db = db;
        }

        public bool Register(User user)
        {
            int isExecuted = 0;

            _db.Users.Add(user);
            isExecuted = _db.SaveChanges();

            if (isExecuted > 0)
            {
                return true;
            }

            return false;
        }
        public bool Login(string userName, string password)
        {
            int isExecuted = 0;

            if (isExecuted > 0)
            {
                return true;
            }

            return false;
        }
        //
        public bool UpdateInfo(User user)
        {
            int isExecuted = 0;

            _db.Entry(user).State = EntityState.Modified;
            isExecuted = _db.SaveChanges();

            if (isExecuted > 0)
            {
                return true;
            }

            return false;
        }
        public List<User> GetUsers()
        {
            return _db.Users.ToList();
        }
        public User GetByID(int id)
        {
            User aUser = _db.Users.FirstOrDefault(c => c.ID == id);

            return aUser;
        }
        public bool DeleteUser(int id)
        {
            int isExecuted = 0;

            User aUser = _db.Users.FirstOrDefault(u => u.ID == id);

            _db.Users.Remove(aUser);
            isExecuted = _db.SaveChanges();

            if (isExecuted > 0)
            {
                return true;
            }

            return false;
        }
    }
}
