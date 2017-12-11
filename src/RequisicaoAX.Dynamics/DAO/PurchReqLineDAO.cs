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
    public class PurchReqLineDAO
    {
        private SqlConnection Conn { get; set; }

        /// <summary>
        /// Construtor com a string de conexao
        /// </summary>
        /// <param name="_conn"></param>
        public PurchReqLineDAO(SqlConnection _conn)
        {
            this.Conn = _conn;
        }

        /// <summary>
        /// Construtor com a string de conexao
        /// </summary>
        /// <param name="_connString"></param>
        public PurchReqLineDAO (string _connString)
        {
            this.Conn = new SqlConnection(_connString);
        }

        /// <summary>
        /// Select pelo RECID e retorna um objeto PurhReqLine
        /// </summary>
        /// <param name="_id"></param>
        /// <returns></returns>
        public PurchReqLine GetById (long _id)
        {
            var query = @"select * from [PURCHREQLINE] where RECID = @Entrada";

            using (Conn)
            {
                try
                {
                    var resultado = Conn.Query<PurchReqLine>(query, new { Entrada = _id }).FirstOrDefault();
                    return resultado;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        /// <summary>
        /// Select all e retorna um objeto PurchReqLine
        /// </summary>
        /// <returns></returns>
        public List<PurchReqLine> GetAll()
        {
            var list = new List<PurchReqLine>();

            using (Conn)
            {
                try
                {
                    var result = Conn.Query<PurchReqLine>("select * from [PURCHREQLINE]");

                    foreach (PurchReqLine purchLine in result)
                    {
                        list.Add(purchLine);
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
