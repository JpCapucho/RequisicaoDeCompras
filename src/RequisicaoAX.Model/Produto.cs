using System;
using System.Collections.Generic;
using System.Text;

namespace RequisicaoAX.Model
{
    /// <summary>
    /// Representação de um produto no sistema
    /// </summary>
    public class Produto
    {
        #region Fields
        /// <summary>
        /// Identificador do produto
        /// </summary>
        /// <remarks>
        /// Codigo unico recebido via integração com o ERP
        /// </remarks>
        public virtual string Id { get; set; }

        /// <summary>
        /// Nome do produto
        /// </summary>
        public virtual string Nome { get; set; }

        /// <summary>
        /// Codigo do produto
        /// </summary>
        public virtual string Codigo { get; set; }




        /// <summary>
        /// Verifica se o produto está disponivel
        /// </summary>
        public virtual bool Disponivel { get; set; }

        /// <summary>
        /// Requisições onde o produto foi utilizado
        /// </summary>
        public virtual IList<Item> Itens { get; set; }

        #endregion

        #region Contructor
        public Produto()
        {
            
        }
        #endregion
    }
}
