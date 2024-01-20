using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dapper_blog.Models;
using dapper_blog.Repository;

namespace dapper_blog.Screens.TagScreens
{
    public static class CreateTagScreen
    {
        public static void Load(){
            Console.Clear();
            CreateTag();
        }

        public static void CreateTag(){
            var repository = new Repository<Tag>(DataBase.Connection);
            Tag tag = new Tag();

            Console.WriteLine("Digite o nome de sua Tag:");
            tag.Name = Console.ReadLine();
            tag.Slug = $"({tag.Name.ToLower()})";
            repository.Create(tag);

            Console.WriteLine("Criado com sucesso");
            Console.ReadKey();
            MenuTagScreen.Load();
        }
    }
}