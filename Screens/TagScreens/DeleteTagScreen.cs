using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dapper_blog.Models;
using dapper_blog.Repository;

namespace dapper_blog.Screens.TagScreens
{
    public class DeleteTagScreen
    {
public static void Load()
        {
            Console.Clear();

            Console.WriteLine("Deletando Uma Tag!");
            Console.WriteLine("--------------------");
            Console.WriteLine("Digite a ID da Tag que deseja excluir:");
            int id = int.Parse(Console.ReadLine()!);
            Delete(id);
            Console.ReadKey();
            MenuTagScreen.Load();
        }
        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Tag>(DataBase.Connection);
                var tag = repository.Get(id);
                if(tag is null){
                    throw new Exception("Tag não encontrada");
                }
                Console.WriteLine($"Tag: {tag.Id} - {tag.Name} - {tag.Slug}");
                Console.WriteLine("Deseja Realmente Deletar? 1 - Sim | 2 - Não");
                int opt = int.Parse(Console.ReadLine()!);
                switch(opt){
                    case 1:
                        repository.Delete(tag);
                        Console.WriteLine("Deletado com sucesso");
                        break;
                    case 2:
                        MenuTagScreen.Load();
                        break;
                }                        
            }catch(Exception ex){
                Console.WriteLine("Não foi possivel Deletar a tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}