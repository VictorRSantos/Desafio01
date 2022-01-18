using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Desafio01.Repositories;

namespace Desafio01.Screens.TagScreens
{
    public static class ListTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            System.Console.WriteLine("Lista de tags");
            List();
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        private static void List()
        {
            var repository = new Repository<Tag>(Database.Connection);

            var tags = repository.Get();

            foreach (var item in tags)
                System.Console.WriteLine($"{item.Id} - {item.Name} ({item.Slug})");


        }
    }
}