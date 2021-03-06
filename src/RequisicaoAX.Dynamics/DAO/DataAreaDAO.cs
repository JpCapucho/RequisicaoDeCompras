﻿using RequisicaoAX.Dynamics.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;

namespace RequisicaoAX.Dynamics.DAO
{
    public class DataAreaDAO
    {
        private SqlConnection Conn { get; set; }

        /// <summary>
        /// Contrutor com a string de conexao
        /// </summary>
        /// <param name="_conn"></param>
        public DataAreaDAO(SqlConnection _conn)
        {
            this.Conn = _conn;
        }

        /// <summary>
        /// Constutor com a stringo de conexao
        /// </summary>
        /// <param name="_connString"></param>
        public DataAreaDAO(string _connString)
        {
            this.Conn = new SqlConnection(_connString);
        }

        /// <summary>
        /// Select pelo ID que retorna um objeto Filial
        /// </summary>
        /// <param name="_id"></param>
        /// <returns></returns>
        public DataArea GetByID(string _id)
        {
            var query = @"select * from [DATAAREA] where ID = @Entrada";

            using (Conn)
            {
                try
                {
                    var resultado = Conn.Query<DataArea>(query, new { Entrada = _id }).SingleOrDefault();
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
        public List<DataArea> GetAll()
        {
            var list = new List<DataArea>();

            using (Conn)
            {
                try
                {
                    var result = Conn.Query<DataArea>("select * from [DATAAREA]");

                    foreach (DataArea filial in result)
                    {
                        list.Add(filial);
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