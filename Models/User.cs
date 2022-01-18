
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace Blog.Models
{

    // Dapper-contrib, pluralizar as tabelas do banco na hora da cconsulta
    // exemplo: nossa tabela é user, ele tenta buscar users.
    // então vamos utilizar um metadado ou notation(Dapper.Contrib.Extensions)

    [Table("[User]")]
    public class User
    {
        public User() => Roles = new List<Role>();

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Bio { get; set; }
        public string Image { get; set; }
        public string Slug { get; set; }

        [Write(false)]
        public List<Role> Roles { get; set; }

    }
}