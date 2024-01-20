using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dapper_blog.Screens.PostScreens
{
    public static class MenuPostScreen
    {
        public static void Load(){
            Console.Clear();
            Console.WriteLine("Gestão de Post");
            Console.WriteLine("--------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar Post");
            Console.WriteLine("2 - Consultar Post por ID");
            Console.WriteLine("3 - Listar posts por tag");
            Console.WriteLine("4 - Atualizar Post");
            Console.WriteLine("5 - Excluir Post");
            Console.WriteLine("6 - Retornar ao menu principal");
            Console.WriteLine();
            Console.WriteLine();
            short opt = short.Parse(Console.ReadLine()!);
            switch(opt){
                case 1:
                    ListPostScreen.Load();
                    break;
                    
            }
        }
    }
}