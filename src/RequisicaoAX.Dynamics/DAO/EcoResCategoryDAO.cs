using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using RequisicaoAX.Dynamics.Model;

namespace RequisicaoAX.Dynamics.DAO
{
    class EcoResCategoryDAO
    {
        private SqlConnection Conn { get; set; }

        /// <summary>
        /// Contrutor com a string de conexao
        /// </summary>
        /// <param name="_conn"></param>
        public EcoResCategoryDAO(SqlConnection _conn)
        {
            this.Conn = _conn;
        }

        /// <summary>
        /// Construtor com a string de conexao
        /// </summary>
        /// <param name="_connString"></param>
        public EcoResCategoryDAO(string _connString)
        {
            this.Conn = new SqlConnection(_connString);
        }

        /// <summary>
        /// Select pelo RECID que retorna um objeto Produto
        /// </summary>
        /// <param name="_id"></param>
        /// <returns></returns>
        public EcoResCategory GetById(long _id)
        {
            var query = @"select * from [ECORESCATEGORY] where RECID = @Entrada ";

            using (Conn)
            {
                try
                {
                    var resultado = Conn.Query<EcoResCategory>(query, new { Entrada = _id }).FirstOrDefault();
                    return resultado;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        /// <summary>
        /// Select All que retornar todos os objetos da tabela
        /// </summary>
        /// <returns></returns>
        public List<EcoResCategory> GetAll()
        {
            var list = new List<EcoResCategory>();

            using (Conn)
            {
                try
                {
                    var result = Conn.Query<EcoResCategory>("select * from [ECORESCATEGORY]");

                    foreach (EcoResCategory categoria in result) {
                        list.Add(categoria);
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
