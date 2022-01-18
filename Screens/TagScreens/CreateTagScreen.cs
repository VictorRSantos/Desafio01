using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Desafio01.Repositories;

namespace Desafio01.Screens.TagScreens
{
    public static class CreateTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            System.Console.WriteLine("Nova tags");
            System.Console.WriteLine("-------------");
            System.Console.Write("Nome: ");
            var name = Console.ReadLine();
            System.Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Create(new Tag
            {
                Name = name,
                Slug = slug
            });

            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Create(Tag tag)
        {

            try
            {
                var repository = new Repository<Tag>(Database.Connection);

                repository.Create(tag);

                Console.WriteLine("Tag cadastrada com sucesso");

            }
            catch (System.Exception ex)
            {

                Console.WriteLine("Não foi possivel salvar a tag");
                Console.WriteLine(ex.Message);
            }

        }

    }
}