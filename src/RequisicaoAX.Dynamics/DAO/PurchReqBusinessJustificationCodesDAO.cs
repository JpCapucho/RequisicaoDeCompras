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
    class PurchReqBusinessJustificationCodesDAO
    {
        private SqlConnection Conn { get; set; }

        /// <summary>
        /// Construtor com a string de conexao
        /// </summary>
        /// <param name="_conn"></param>
        public PurchReqBusinessJustificationCodesDAO(SqlConnection _conn)
        {
            this.Conn = _conn;
        }

        /// <summary>
        /// Construtor com a string de conexao
        /// </summary>
        /// <param name="_connString"></param>
        public PurchReqBusinessJustificationCodesDAO(string _connString)
        {
            this.Conn = new SqlConnection(_connString);
        }

        /// <summary>
        /// Select pelo RECID e retorna um objeto PurchReqBusinessJustificationCodes
        /// </summary>
        /// <param name="_id"></param>
        /// <returns></returns>
        public PurchReqBusinessJustificationCodes GetById(long _id)
        {
            var query = @"select * from [PURCHREQBUSINESSJUSTIFICATIONCODES] where RECID = @Entrada";

            using (Conn)
            {
                try
                {
                    var resultado = Conn.Query<PurchReqBusinessJustificationCodes>(query, new { Entrada = _id }).FirstOrDefault();
                    return resultado;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        /// <summary>
        /// Select all e retorna um objeto PurchReqBusinessJustificationCodes
        /// </summary>
        /// <returns></returns>
        public List<PurchReqBusinessJustificationCodes> GetAll()
        {
            var list = new List<PurchReqBusinessJustificationCodes>();

            using (Conn)
            {
                try
                {
                    var result = Conn.Query<PurchReqBusinessJustificationCodes>("select * from [PURCHREQBUSINESSJUSTIFICATIONCODES]");

                    foreach (PurchReqBusinessJustificationCodes justificacao in result)
                    {
                        list.Add(justificacao);
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
