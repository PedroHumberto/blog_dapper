using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dapper_blog.Models;
using dapper_blog.Repository;

namespace dapper_blog.Screens.TagScreens
{
    public static class ListTagScreen
    {
        public static void Load()
        {
            List();
        }

        private static void List()
        {
            var repository = new Repository<Tag>(DataBase.Connection);
            var tags = repository.GetAll();
            foreach(Tag item in tags){
                Console.WriteLine($"{item.Id} - {item.Name} - {item.Slug}");

            }
            Console.ReadKey();
            MenuTagScreen.Load();
        }
    }
}