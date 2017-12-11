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
    class PartitionDAO
    {
        private SqlConnection Conn { get; set; }


        /// <summary>
        /// Construtor com a string de conexao
        /// </summary>
        /// <param name="_conn"></param>
        public PartitionDAO (SqlConnection _conn)
        {
            this.Conn = _conn;
        }

        /// <summary>
        /// Construtor com a string de conexao
        /// </summary>
        /// <param name="_connString"></param>
        public PartitionDAO (string _connString)
        {
            this.Conn = new SqlConnection(_connString);
        }

        /// <summary>
        /// Select pelo RECID que retorna um objeto FiscalDocumentBr
        /// </summary>
        /// <param name="_id"></param>
        /// <returns></returns>
        public Partition GetById (long _id)
        {
            var query = @"select * from [PARTITIONS] where RECID = @Entrada";

            using (Conn)
            {
                try
                {
                    var resultado = Conn.Query<Partition>(query, new { Entrada = _id }).FirstOrDefault();
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
        public  List<FiscalEstablishment_BR> GetAll()
        {
            var list = new List<FiscalEstablishment_BR>();

            using (Conn)
            {
                try
                {
                    var result = Conn.Query<FiscalEstablishment_BR>("select * from [PARTITIONS]");

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
