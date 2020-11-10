using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectEnd.WebUI.Interface
{
    public interface IBaseInterface<T> where T : class
    {

        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        Task<List<T>> GetAll();
    }
}
