using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using dapper_blog.Models;
using Microsoft.Data.SqlClient;

namespace dapper_blog.Repository
{
    public class PostRepository : Repository<Post>
    {
        private readonly SqlConnection _connection;

        public PostRepository(SqlConnection connection) : base(connection)
        {
            _connection = connection;
        }

        public IEnumerable<Post> GetPosts()
        {
            

            return new List<Post>();
        }
    }
}