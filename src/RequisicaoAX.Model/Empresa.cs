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
    	/// <summary>
    	/// Identificador unico
    	/// </summary>
        public virtual string Id { get; set; }
        
        /// <summary>
        /// Nome da empresa
        /// </summary>
        public virtual string Nome { get; set; }
        
        /// <summary>
        /// Filiais vinculadas a esta entidade
        /// </summary>
        public IList<Filial> Filiais { get; set; }
    }

}
