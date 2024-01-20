using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using dapper_blog.Models;
using dapper_blog.Repository;
using Microsoft.IdentityModel.Tokens;

namespace dapper_blog.Screens.TagScreens
{
    public static class ListAllTagsWithPosts
    {
        public static void Load(){
            GetAllTagsWithPost();
            Console.ReadLine();
            MenuTagScreen.Load();
        }

        private static void GetAllTagsWithPost(){
            var rep = new TagRepository(DataBase.Connection);
            var tagsPosts = rep.GetTagPost();
            Console.WriteLine("--ALL TAGS WITH POST---");
            Console.WriteLine();
            foreach(var tagPost in tagsPosts){

                
                Console.WriteLine("Author - " + tagPost.AuthorName);
                Console.WriteLine("Post Tag - " + tagPost.TagName);
                Console.WriteLine("Post Title - " + tagPost.Title);
                Console.WriteLine();
                Console.WriteLine();
                
            }
        }
            
    }
}