using Dapper;
using RequisicaoAX.Dynamics.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequisicaoAX.Dynamics.DAO
{
    public class EcoResProductDAO
    {
        private SqlConnection Conn { get; set; }

        /// <summary>
        /// Contrutor com a string de conexao
        /// </summary>
        /// <param name="_conn"></param>
        public EcoResProductDAO(SqlConnection _conn)
        {
            this.Conn = _conn;
        }

        /// <summary>
        /// Construtor com a stringo de conexao
        /// </summary>
        /// <param name="_connString"></param>
        public EcoResProductDAO(string _connString)
        {
            this.Conn = new SqlConnection(_connString);
        }

        /// <summary>
        /// Select pelo RECID que retorna um objeto Produto
        /// </summary>
        /// <param name="_id"></param>
        /// <returns></returns>
        public EcoResProduct GetByID(long _id)
        {
            var query = @"select * from [ECORESPRODUCT] where RECID = @Entrada";

            using (Conn)
            {
                try
                {
                    var resultado = Conn.Query<EcoResProduct>(query, new { Entrada = _id }).SingleOrDefault();
                    return resultado;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        /// <summary>
        /// Select ALl que retorna todos os objetos da tabela
        /// </summary>
        /// <returns></returns>
        public List<EcoResProduct> GetAll()
        {
            var list = new List<EcoResProduct>();

            using (Conn)
            {
                try
                {
                    var result = Conn.Query<EcoResProduct>("select * from [ECORESPRODUCT]");

                    foreach (EcoResProduct produto in result)
                    {
                        list.Add(produto);
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
