using System;
using System.Collections.Generic;
using System.Text;

namespace RequisicaoAX.Model
{
    /// <summary>
    /// Item da requisição de compra
    /// </summary>
    public class Item
    {
        #region Fields
        /// <summary>
        /// Identificador do item
        /// </summary>
        public virtual long Id { get; set; }

        /// <summary>
        /// Descrição do item
        /// </summary>
        /// <remarks>
        /// Utilizar por padrão a descrição do produto
        /// </remarks>
        public virtual string Descricao { get; set; }

        /// <summary>
        /// Campo de complemento
        /// </summary>
        public virtual string Complemento { get; set; }

        /// <summary>
        /// Produto vinculado
        /// </summary>
        public virtual Produto Produto { get; set; }

        #endregion

        #region Constructor
        public Item() { }
        #endregion

    }
}
