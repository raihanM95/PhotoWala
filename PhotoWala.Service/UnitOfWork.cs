using PhotoWala.DatabaseContext.DatabaseContext;
using PhotoWala.Interface;
using PhotoWala.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoWala.Service
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PhotoWalaDbContext _db;
        //private IGenericService<User> _genericService;

        public UnitOfWork(PhotoWalaDbContext db)
        {
            _db = db;
        }

        //public IGenericService<User> GenericService
        //{
        //    get { return _genericService = _genericService ?? new GenericService<User>(_db); }
        //}

        public void Commit()
        {
            _db.SaveChanges();
        }

        public void Rollback()
        {
            _db.Dispose();
        }
    }
}
