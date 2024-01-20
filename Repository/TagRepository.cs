using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using dapper_blog.Models;
using Microsoft.Data.SqlClient;

namespace dapper_blog.Repository
{
    public class TagRepository : Repository<Tag>
    {
        private readonly SqlConnection _connection;
        public TagRepository(SqlConnection connection) : base(connection){

            _connection = connection;
        }

        public IQueryable<Tag> GetTagInitiateWithLetter(char letter)
            => _connection.Query<Tag>("SELECT * FROM Tag WHERE LEFT(Name, 1) = @letter", new { letter }).AsQueryable();
        
        public IQueryable<TagPost> GetTagPost(){
            var query = @"
            SELECT 
                t.Id AS tagId,
                t.Name as TagName,
                t.Slug,
                p.Id As postId,
                p.Title,
                p.Summary,
                p.Body,
                p.Slug,
                p.CreateDate,
                p.AuthorId,
                u.Name AS AuthorName,
                c.Id AS categoryId,
                c.Name AS CategoryName
            FROM Tag t
                INNER JOIN PostTag pt ON t.Id = pt.TagId
                INNER JOIN Post p ON pt.PostId = p.Id
                INNER JOIN Category c ON p.CategoryId = c.Id
                INNER JOIN [User] u ON p.AuthorId = u.Id
                ";
            
            var result = _connection.Query<TagPost, Tag, TagPost>(query, (TagPost, Tag) =>{
                return TagPost;
            }, splitOn: "tagId, postId, categoryId");

            return result.AsQueryable();
        }
    }
}