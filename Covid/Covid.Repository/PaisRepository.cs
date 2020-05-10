using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Covid.Repository
{
    public class PaisRepository : IpaisRepository
    {
        private IConfiguration _configuracoes;

        public PaisRepository(IConfiguration config)
        {
            _configuracoes = config;
        }

        public IEnumerable<DTO.Pais> ListarTodos()
        {
            using (MySqlConnection conexao = new MySqlConnection(
                _configuracoes.GetConnectionString("banco")))
            {
                var teste = conexao.Query<DTO.Pais>("Select IdPais, NomePais  from Pais");

                return teste;
            }
        }

    }
}
