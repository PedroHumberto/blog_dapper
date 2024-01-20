using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dapper_blog.Models;
using dapper_blog.Repository;

namespace dapper_blog.Screens.TagScreens
{
    public class UpdateTagScreen
    {
        public static void Load()
        {
            Tag tag = new Tag();
            Console.Clear();

            Console.WriteLine("Atualizando Uma Tag!");
            Console.WriteLine("--------------------");
            Console.WriteLine("Digite a ID de sua Tag que deseja alterar:");
            int id = int.Parse(Console.ReadLine()!);



            Update(id);

        }
        public static void Update(int id)
        {
            try
            {
                var repository = new Repository<Tag>(DataBase.Connection);
                var tag = repository.Get(id);
                if (tag is null)
                {
                    throw new Exception("ID não encontrado");
                }
                Console.WriteLine("Digite o novo nome de sua Tag:");
                tag.Name = Console.ReadLine();

                tag.Slug = $"({tag.Name.ToLower()})";

                repository.Update(tag);
                Console.WriteLine("Atualizado com sucesso");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possivel atualizar a tag");
                Console.WriteLine(ex.Message);
                Console.ReadKey();

                MenuTagScreen.Load();

            }
        }
    }
}