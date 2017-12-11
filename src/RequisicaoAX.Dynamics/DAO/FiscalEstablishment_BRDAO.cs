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
    class FiscalEstablishment_BRDAO
    {
        private SqlConnection Conn { get; set; }

        /// <summary>
        /// Contrutor com a string de conexao
        /// </summary>
        /// <param name="_conn"></param>
        public FiscalEstablishment_BRDAO(SqlConnection _conn)
        {
            this.Conn = _conn;
        }

        /// <summary>
        /// Construtor com a string de conexao
        /// </summary>
        /// <param name="_connString"></param>
        public FiscalEstablishment_BRDAO(string _connString)
        {
            this.Conn = new SqlConnection(_connString);
        }

        /// <summary>
        /// Select pelo RECID que retorna um objeto FiscalDocumentBR
        /// </summary>
        /// <param name="_id"></param>
        /// <returns></returns>
        public FiscalEstablishment_BR GetById(long _id)
        {
            var query = @"select * from [FISCALDOCUMENT_BR] where RECID = @Entrada";

            using (Conn)
            {
                try
                {
                    var resultado = Conn.Query<FiscalEstablishment_BR>(query, new { Entrada = _id}).FirstOrDefault();
                    return resultado;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public List<FiscalEstablishment_BR> GetAll()
        {
            var list = new List<FiscalEstablishment_BR>();

            using (Conn)
            {
                try
                {
                    var result = Conn.Query<FiscalEstablishment_BR>("select * from [FISCALDOCUMENT_BR]");

                    foreach (FiscalEstablishment_BR fiscalDocumentBr in result)
                    {
                        list.Add(fiscalDocumentBr);
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
