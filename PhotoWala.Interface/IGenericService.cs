using PhotoWala.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoWala.Interface
{
    public interface IGenericService<T> where T : class
    {
        List<T> GetAll();
        T GetById(int id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(int id);
    }
}
