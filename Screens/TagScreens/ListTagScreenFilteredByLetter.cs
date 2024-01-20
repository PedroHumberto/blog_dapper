using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dapper_blog.Models;
using dapper_blog.Repository;

namespace dapper_blog.Screens.TagScreens
{
    public static class ListTagScreenFilteredByLetter
    {
        public static void Load()
        {
            var repository = new TagRepository(DataBase.Connection);
            Console.Clear();
            Console.WriteLine("Filtro por Letrar digitada");
            Console.WriteLine("------------------------");
            Console.WriteLine("Digite uma Letra");
            char letter = char.Parse(Console.ReadLine()!);
            try
            {
                var tags = repository.GetTagInitiateWithLetter(letter);
                foreach (Tag item in tags)
                {
                    Console.WriteLine($"{item.Id} - {item.Name} - {item.Slug}");
                }

                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro:");
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
            MenuTagScreen.Load();
        }
    }
}