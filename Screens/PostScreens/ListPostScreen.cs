using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using dapper_blog.Models;
using dapper_blog.Repository;

namespace dapper_blog.Screens.PostScreens
{
    public static class ListPostScreen
    {
        public static void Load(){
            GetAllPosts();
            Console.ReadLine();
            MenuPostScreen.Load();
        }

        public static void GetAllPosts(){
            var repository = new PostRepository(DataBase.Connection);

            var posts = repository.GetPosts();
            foreach(var post in posts){
                Console.WriteLine($"{post.Id} - {post.Title} - {post.Tags} ");
                Console.WriteLine(post.Body);
            }
        }
    }
}