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
    	/// <summary>
    	/// Identificador unico do registro
    	/// </summary>
        public virtual string Id { get; set; }
        
        /// <summary>
        /// Nome da filial
        /// </summary>
        public virtual string Nome { get; set; }
        
        /// <summary>
        /// <see cref="Empresa"/> vinculada a esta entidade
        /// </summary>
        public virtual Empresa Empresa { get; set; }
    }
}
