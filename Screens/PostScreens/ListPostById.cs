using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dapper_blog.Models;
using dapper_blog.Repository;

namespace dapper_blog.Screens.PostScreens
{
    public static class ListPostById
    {
        public static void Load(){
            Console.Clear();
            Console.WriteLine("Digite a ID");
            var id = int.Parse(Console.ReadLine()!);
        }

        private static void GetPostById(int id){
            var rep = new Repository<Post>(DataBase.Connection);

            Post post = rep.Get(id);

            Console.WriteLine($"{post.Id} - {post.Title} - {post.Author}");
            Console.WriteLine(post.Body);
            Console.WriteLine("Tags: " + post.Tags);
        }
    }
}