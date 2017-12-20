using System;
using System.Collections.Generic;
using System.Text;

namespace RequisicaoAX.Model
{
    /// <summary>
    /// Representa uma filial da empresa
    /// </summary>
    public class Filial
    {
        #region Fields
        /// <summary>
        /// Identificador unico do registro
        /// </summary>
        public virtual string Id { get; set; }

        /// <summary>
        /// Nome da filial
        /// </summary>
        public virtual string Nome { get; set; }

        public virtual string CNPJ { get; set; }

        public virtual bool Visivel { get; set; }

        /// <summary>
        /// <see cref="Empresa"/> vinculada a esta entidade
        /// </summary>
        public virtual Empresa Empresa { get; set; }

        /// <summary>
        /// Usuarios da filial
        /// </summary>
        public virtual IList<Usuario> Usuarios { get; set; }

        public virtual IList<Item> Itens { get; set; }
        #endregion

        #region Constructor
        public Filial() { }
        #endregion
    }
}
