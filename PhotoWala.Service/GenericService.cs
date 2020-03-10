using Microsoft.EntityFrameworkCore;
using PhotoWala.DatabaseContext.DatabaseContext;
using PhotoWala.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhotoWala.Service
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        private readonly PhotoWalaDbContext _db;
        private DbSet<T> table;

        public GenericService(PhotoWalaDbContext db)
        {
            _db = db;
            table = _db.Set<T>();
        }

        public List<T> GetAll()
        {
            return table.ToList();
        }
        public T GetById(int id)
        {
            return table.Find(id);
        }
        public void Insert(T obj)
        {
            table.Add(obj);
        }
        public void Update(T obj)
        {
            table.Attach(obj);
            _db.Entry(obj).State = EntityState.Modified;
        }
        public void Delete(int id)
        {
            T exists = table.Find(id);
            table.Remove(exists);
        }
    }
}
