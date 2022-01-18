using System;
using Blog.Models;
using Desafio01.Repositories;
using Desafio01.Screens.TagScreens;
using Microsoft.Data.SqlClient;

namespace Desafio01
{
    class Program
    {
        private const string ConnectionString = @"Server=DESKTOP\SQLEXPRESS;Database=Blog;User Id = sa; Password=123456;TrustServerCertificate=True";

        static void Main(string[] args)
        {
            Database.Connection = new SqlConnection(ConnectionString);
            Database.Connection.Open();
            Load();



            

            Console.ReadKey();
            Database.Connection.Close();
        }

        private static void Load()
        {
            Console.Clear();
            Console.WriteLine("Meu Blog");
            Console.WriteLine("-----------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Gestão de usuário");
            Console.WriteLine("2 - Gestão de perfil");
            Console.WriteLine("3 - Gestão de categoria");
            Console.WriteLine("4 - Gestão de tag");
            Console.WriteLine("5 - Vincular perfil/usuário");
            Console.WriteLine("6 - Vincular post/tag");
            Console.WriteLine("7 - Relatórios");
            Console.WriteLine();
            Console.WriteLine();

            System.Console.Write("opçao: ");
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    MenuTagScreen.Load();
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                default: Load(); break;
            }
        }


    }
}
