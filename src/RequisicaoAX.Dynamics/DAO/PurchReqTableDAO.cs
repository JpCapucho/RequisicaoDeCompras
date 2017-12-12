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
    public class PurchReqTableDAO
    {
        private SqlConnection Conn { get; set; }

        /// <summary>
        /// Construtor com a string de conexao
        /// </summary>
        /// <param name="_conn"></param>
        public PurchReqTableDAO(SqlConnection _conn)
        {
            this.Conn = _conn;
        }

        /// <summary>
        /// Construtor com a string de conexao
        /// </summary>
        /// <param name="_connString"></param>
        public PurchReqTableDAO(string _connString)
        {
            this.Conn = new SqlConnection(_connString);
        }

        /// <summary>
        /// Select pelo RECID e retorna um objeto PurchreqTable
        /// </summary>
        /// <param name="_id"></param>
        /// <returns></returns>
        //public PurchReqTable GetById(long _id)
        //{
        //    var query = @"select * from [PURCHREQTABLE] where RECID = @Entrada";

        //    using (Conn)
        //    {
        //        try
        //        {
        //            var resultado = Conn.Query<PurchReqTable>(query, new { Entrada = _id }).FirstOrDefault();
        //            return resultado;
        //        }
        //        catch (Exception ex)
        //        {
        //            throw ex;
        //        }
        //    }
        //}

        /// <summary>
        /// Select pelo PURCHREQID e retorna um objeto PurchReqTable
        /// </summary>
        /// <param name = "_id" ></ param >
        /// < returns ></ returns >
        //public PurchReqTable GetByPurchReqId(long _id)
        //{
        //    var query = @"select * from [PURCHREQTABLE] where PURCHREQID = @Entrada";

        //    using (Conn)
        //    {
        //        try
        //        {
        //            var resultado = Conn.Query<PurchReqTable>(query, new { Entrada = _id }).FirstOrDefault();
        //            return resultado;
        //        }
        //        catch (Exception ex)
        //        {
        //            throw ex;
        //        }
        //    }
        //}




        /// <summary>
        /// Select pelo RECID e retorna um objeto PurchreqTable
        /// </summary>
        /// <param name="_id"></param>
        /// <returns></returns>
        public List<PurchReqTable> GetById(long _id)
        {
            var query = @"  SELECT *
                            FROM [PURCHREQLINE] PL
                            INNER JOIN [PURCHREQTABLE] PT ON (PL.PURCHREQTABLE = PT.RECID) where RECID = @Entrada";

            using (Conn)
            {
                try
                {
                    var resultado = Conn.Query<PurchReqTable, PurchReqLine, PurchReqTable>(query,
                        (purchTable, purchLine) => { purchTable.TableLines.Add(purchLine); return purchTable; },
                        new { Entrada = _id },
                        splitOn: "RECID"
                        );
                    return resultado.ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        /// <summary>
        /// Select pelo PURCHREQID que retorna um objeto PurchTable
        /// </summary>
        /// <param name="_id"></param>
        /// <returns></returns>
        public List<PurchReqTable> GetByPurchReqId(long _id)
        {
            var query = @"  SELECT *
                            FROM [PURCHREQLINE] PL
                            INNER JOIN [PURCHREQTABLE] PT ON (PL.PURCHREQTABLE = PT.RECID) where PURCHREQID = @Entrada";

            using (Conn)
            {
                try
                {
                    var resultado = Conn.Query<PurchReqTable, PurchReqLine, PurchReqTable>(query,
                        (purchTable, purchLine) => { purchTable.TableLines.Add(purchLine); return purchTable; },
                        new { Entrada = _id },
                        splitOn: "RECID"
                        );
                    return resultado.ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        /// <summary>
        /// Select All que retorna todos os objetos da tabela PurchReqTable
        /// </summary>
        /// <returns></returns>
        public List<PurchReqTable> GetAll()
        {
            var query = @"  SELECT *
                            FROM [PURCHREQLINE] PL
                            INNER JOIN [PURCHREQTABLE] PT ON (PL.PURCHREQTABLE = PT.RECID)";

            using (Conn)
            {
                try
                {
                    var resultado = Conn.Query<PurchReqTable, PurchReqLine, PurchReqTable>(query,
                        (purchTable, purchLine) => { purchTable.TableLines.Add(purchLine); return purchTable; },
                        splitOn: "RECID"
                        );
                    return resultado.ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }


        //public List<PurchReqTable> GetAll()
        //{
        //    var list = new List<PurchReqTable>();

        //    using (Conn)
        //    {
        //        try
        //        {
        //            var result = Conn.Query<PurchReqTable>("select * from [PURCHREQTABLE]");

        //            foreach (PurchReqTable purchTable in result)
        //            {
        //                list.Add(purchTable);
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            throw ex;
        //        }
        //        return list;
        //    }
        //}

    }
}
