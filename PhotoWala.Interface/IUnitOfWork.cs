using PhotoWala.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoWala.Interface
{
    public interface IUnitOfWork
    {
        //IGenericService<User> GenericService { get; }

        void Commit();
        void Rollback();
    }
}
