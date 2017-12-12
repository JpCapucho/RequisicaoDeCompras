using RequisicaoAX.Dynamics.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace RequisicaoAX.Dynamics.DAO
{
    class InventTableDAO
    {
        private SqlConnection Conn { get; set; }

        /// <summary>
        /// Construtor com a string de conexao
        /// </summary>
        /// <param name="_conn"></param>
        public InventTableDAO(SqlConnection _conn)
        {
            this.Conn = _conn;
        }

        /// <summary>
        /// Construtor com a string de conexao
        /// </summary>
        /// <param name="_connString"></param>
        public InventTableDAO(string _connString)
        {
            this.Conn = new SqlConnection(_connString);
        }

        /// <summary>
        /// Select pelo ITEMID e retorna um objeto InventTable
        /// </summary>
        /// <param name="_id"></param>
        /// <returns></returns>
        public InventTable GetByiTemId(long _id)
        {
            var query = @"select * from [INVENTTABLE] where ITEMID = @Entrada";

            using (Conn)
            {
                try
                {
                    var resultado = Conn.Query<InventTable>(query, new { Entrada = _id }).SingleOrDefault();
                    return resultado;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        /// <summary>
        /// Select All que retorna todos os objetos da tabela
        /// </summary>
        /// <returns></returns>
        public List<InventTable> GetAll()
        {
            var list = new List<InventTable>();

            using (Conn)
            {
                try
                {
                    var result = Conn.Query<InventTable>("select * from [INVENTTABLE]");

                    foreach (InventTable produtos in result)
                    {
                        list.Add(produtos);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return list;
            }
        }
    }
}