using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dapper_blog.Models
{
    public interface IRepository<TModel> where TModel : class
    {
            public IEnumerable<TModel> GetAll();
            public void Read();
            public void Create();
            public void Update();
            public void Delete();
    }   
}