using Microsoft.EntityFrameworkCore;
using ProjectEnd.WebUI.Data;
using ProjectEnd.WebUI.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectEnd.WebUI.Implementations
{
    public class BaseInterface<T> : IBaseInterface<T> where T : class
    {
        private readonly StarexDbContext _starexDbContext;
        public BaseInterface(StarexDbContext starexDbContext)
        {
            _starexDbContext = starexDbContext;
        }
        public void Add(T entity)
        {
            _starexDbContext.Add<T>(entity);
         }

        public void Delete(T entity)
        {
            _starexDbContext.Remove<T>(entity);
        }

        public async Task<List<T>> GetAll()
        {
           return await _starexDbContext.Set<T>().ToListAsync();
        }

        public void Update(T entity)
        {
            _starexDbContext.Set<T>().Update(entity);
        }
    }
}
