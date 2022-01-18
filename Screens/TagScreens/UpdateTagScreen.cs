using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Desafio01.Repositories;

namespace Desafio01.Screens.TagScreens
{
    public static class UpdateTagScreen
    {

        public static void Load()
        {

            Console.Clear();
            System.Console.WriteLine("Atualizando uma tags");
            System.Console.WriteLine("-------------");
            System.Console.Write("Id: ");
            var id = int.Parse(Console.ReadLine());
            System.Console.Write("Nome: ");
            var name = Console.ReadLine();
            System.Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Update(new Tag
            {
                Id = id,
                Name = name,
                Slug = slug
            });

            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Update(Tag tag)
        {

            try
            {
                var repository = new Repository<Tag>(Database.Connection);

                repository.Update(tag);

                Console.WriteLine("Tag atualizada com sucesso");

            }
            catch (System.Exception ex)
            {

                Console.WriteLine("Não foi possivel atualizar a tag");
                Console.WriteLine(ex.Message);
            }

        }

    }
}