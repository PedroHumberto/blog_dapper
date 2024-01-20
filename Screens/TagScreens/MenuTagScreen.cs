using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dapper_blog.Models;
using dapper_blog.Repository;

namespace dapper_blog.Screens.TagScreens
{
    public static class MenuTagScreen
    {
        public static void Load(){
            Console.WriteLine("Gestão de Tags");
            Console.WriteLine("--------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar Tags");
            Console.WriteLine("2 - Cadastrar Tags");
            Console.WriteLine("3 - Atualizar Tags");
            Console.WriteLine("4 - Excluir Tags");
            Console.WriteLine("5 - Filtrar Tag que inicie por uma letra");
            Console.WriteLine("6 - Listar Todos as Tags com Post");
            Console.WriteLine("7 - Retornar ao menu principal");
            Console.WriteLine();
            Console.WriteLine();
            short opt = short.Parse(Console.ReadLine()!);

            switch(opt){
                case 1:
                    ListTagScreen.Load();
                    break;
                case 2:
                    CreateTagScreen.Load();
                    break;
                case 3:
                    UpdateTagScreen.Load();
                    break;
                case 4:
                    DeleteTagScreen.Load();
                    break;
                case 5:
                    ListTagScreenFilteredByLetter.Load();
                    break;
                case 6:
                    ListAllTagsWithPosts.Load();
                    break;
                case 7:
                    HomeScreen.Load();
                    break;
                default: Load(); break;
            }



        }
    }
}