using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Desafio01.Repositories
{
    public class Repository<TModel> where TModel : class
    {
        private readonly SqlConnection _connection;

        public Repository(SqlConnection connnection)
        {
            _connection = connnection;
        }

        public IEnumerable<TModel> Get() => _connection.GetAll<TModel>();
        public TModel Get(int id) => _connection.Get<TModel>(id);
        public void Create(TModel model) => _connection.Insert<TModel>(model);
        public void Update(TModel model) => _connection.Update<TModel>(model);
        public void Delete(int id)
        {
            var resultado = _connection.Get<TModel>(id);

            _connection.Delete<TModel>(resultado);




        }


    }
}