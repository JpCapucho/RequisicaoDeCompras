using System;

namespace RequisicaoAX.Model
{
    /// <summary>
    /// Representa um usuario do sistema
    /// </summary>
    public class Usuario
    {
        #region Fields
        /// <summary>
        /// Identificador unico de cada usuario
        /// </summary>
        public virtual long Id { get; set; }

        /// <summary>
        /// Nome do Usuario
        /// </summary>
        public virtual String Nome { get; set; }

        /// <summary>
        /// Dominio no qual o usuario pertence
        /// </summary>
        public virtual string Dominio { get; set; }

        /// <summary>
        /// Identificador do usuario no sistema
        /// </summary>
        /// <remarks>
        /// Numero SID
        /// </remarks>
        /// <example>
        /// <code>whoami /user</code>
        /// </example>
        public virtual string SID { get; set; }

        /// <summary>
        /// Se o usuario for um aprovador
        /// </summary>
        /// <remarks>
        /// Verdadeiro quando o usuario for um aprovador
        /// </remarks>
        public virtual bool Aprovador { get; set; }

        /// <summary>
        /// Se o usuario for um administrador
        /// </summary>
        /// <remarks>
        /// Verdadeiro quando o usuario for um administrador
        /// </remarks>
        public virtual bool Admin { get; set; }

        /// <summary>
        /// Codigo do trabalhador
        /// </summary>
        public virtual string CodigoTrabalhador { get; set; }

        /// <summary>
        /// identificador unico do registro
        /// </summary>
        public virtual long RecId { get; set; }


        /// <summary>
        /// Filial vinculada
        /// </summary>
        public virtual Filial Filial { get; set; }
        #endregion

        #region Contructor

        /// <summary>
        /// Contrutor da classe
        /// </summary>
        public Usuario()
        {
            
        }

        #endregion
    }
}
