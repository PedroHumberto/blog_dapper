using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dapper_blog.Screens.PostScreens;
using dapper_blog.Screens.TagScreens;

namespace dapper_blog.Screens
{
    public static class HomeScreen
    {
        public static void Load(){
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("--------------");
            Console.WriteLine();
            Console.WriteLine("1 - Gestão de usuario");
            Console.WriteLine("2 - Gestão de Perfil");
            Console.WriteLine("3 - Gestão de Categoria");
            Console.WriteLine("4 - Gestão de Tag");
            Console.WriteLine("5 - Gestão de Post");
            Console.WriteLine("6 - Vincular perfil/usuario");
            Console.WriteLine("7 - Vincular post/tag");
            Console.WriteLine("8 - Relatorios");
            Console.WriteLine();
            Console.WriteLine();
            var opt = short.Parse(Console.ReadLine()!);

            switch(opt){
                case 4:
                    MenuTagScreen.Load();
                    break;
                case 5:
                    MenuPostScreen.Load();
                    break;
            }
        }
    }
}