using System;
using System.Collections.Generic;
using System.Text;

namespace RequisicaoAX.Model
{
	/// <summary>
	/// Representa uma empresa
	/// </summary>
    public class Empresa
    {
        #region Fields
        /// <summary>
        /// Identificador unico
        /// </summary>
        public virtual string Id { get; set; }
        
        /// <summary>
        /// Nome da empresa
        /// </summary>
        public virtual string Nome { get; set; }


        public virtual bool Visivel { get; set; }

        /// <summary>
        /// Filiais vinculadas a esta entidade
        /// </summary>
        public virtual IList<Filial> Filiais { get; set; }

        /// <summary>
        /// Requisições vinculadas
        /// </summary>
        public virtual IList<Requisicao> Requisicoes { get; set; }

        #endregion

        #region Constructor
        public Empresa() { }
        #endregion
    }

}
