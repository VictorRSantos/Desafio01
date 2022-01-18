using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Desafio01.Repositories;

namespace Desafio01.Screens.TagScreens
{
    public static class DeleteTagScreen
    {
        public static void Load()
        {

            Console.Clear();
            System.Console.WriteLine("Excluir uma tags");
            System.Console.WriteLine("-------------");
            System.Console.WriteLine("Qual o id da tag que deseja excluir? ");
            System.Console.Write("Id: ");
            var id = int.Parse(Console.ReadLine());

            Delete(id);

            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Delete(int id)
        {

            try
            {
                var repository = new Repository<Tag>(Database.Connection);

                repository.Delete(id);

                Console.WriteLine("Tag excluida com sucesso");

            }
            catch (System.Exception ex)
            {

                Console.WriteLine("Não foi possivel excluir a tag");
                Console.WriteLine(ex.Message);
            }

        }


    }
}