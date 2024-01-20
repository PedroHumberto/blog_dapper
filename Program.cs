using Dapper.Contrib.Extensions;
using dapper_blog.Models;
using dapper_blog.Repository;
using dapper_blog.Screens;
using dapper_blog.Screens.TagScreens;
using Microsoft.Data.SqlClient;

namespace dapper_blog
{
    class Program
    {
        private const string CONNECTION_STRING = @"server=localhost;database=Blog;Trust Server Certificate=true;User ID=sa;Password=1q2w3e4r@#$";

        static void Main(string[] args)
        {
            DataBase.Connection = new SqlConnection(CONNECTION_STRING);
            DataBase.Connection.Open();
            HomeScreen.Load();
            Console.ReadKey();

            DataBase.Connection.Close();
        }




        

        private static void ReadUser(){
            using(var connection = new SqlConnection(CONNECTION_STRING)){
                var user = connection.Get<User>(1);             
                Console.WriteLine(user.Name);
            }
        }

        private static void ReadUsers(SqlConnection connection){
            var repository = new UserRepository(connection);

            var users = repository.GetAll();

            foreach(var u in users)
                Console.WriteLine($"{u.Id} - {u.Name} - {u.Email}");

            
            
        }

        private static void CreateUser(){
            var user = new User(){
                Name = "Teste",
                Bio = "Minha Teste Bio",
                Email = "teste@email.com",
                Image = "https://testeimagem",
                PasswordHash = "HASH TESTE",
                Slug = "teste-meu"
            };

                using(var connection = new SqlConnection(CONNECTION_STRING)){
                var users = connection.Insert<User>(user);
                Console.WriteLine(user.Name);
            }
        }

            private static void UpdateUser(){
            var user = new User(){
                Id = 2,
                Name = "Teste Alterando 1",
                Bio = "Minha Alterei a minha Bio",
                Email = "testealterado@email.com",
                Image = "https://testeimagem",
                PasswordHash = "HASH TESTE",
                Slug = "teste-alterado-1"
            };

                using(var connection = new SqlConnection(CONNECTION_STRING)){
                connection.Update<User>(user);
                Console.WriteLine("atualizado com sucesso");
            }
        }
            private static void DeleteUser(){
                using(var connection = new SqlConnection(CONNECTION_STRING)){
                User user = connection.Get<User>(2);

                connection.Delete<User>(user);

                Console.WriteLine("Deletado com sucesso");
            }
        }

        private static void ReadRoles(SqlConnection connection){
            var repository = new RoleRepository(connection);

            var roles = repository.GetAll();

            foreach(var r in roles)
                Console.WriteLine($"{r.Id} - {r.Name} - {r.Slug}");
        }

    }
}