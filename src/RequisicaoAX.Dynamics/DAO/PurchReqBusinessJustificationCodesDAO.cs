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

        public PurchReqBusinessJustificationCodesDAO(SqlConnection _conn)
        {
            this.Conn = _conn;
        }

        public PurchReqBusinessJustificationCodesDAO(string _connString)
        {
            this.Conn = new SqlConnection(_connString);
        }

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
