using DotNetCoreApiStarter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Assignment_Project.Data.Repositories.Interface
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        T GetById(string id);
        IQueryable<T> GetAll();
        T Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
