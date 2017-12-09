/*
 * Created by SharpDevelop.
 * User: Gamer01
 * Date: 09/12/2017
 * Time: 01:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace RequisicaoAX.Model
{
	/// <summary>
	/// Partição do sistema
	/// </summary>
    /// <remarks>
    /// Dados de integração com o ERP
    /// </remarks>
	public class Particao
	{
        #region Fields
        /// <summary>
        /// Identificador da particao
        /// </summary>
        public virtual string Id { get; set; }
		
        /// <summary>
        /// Nome da particao
        /// </summary>
		public virtual string Nome { get; set; }

        #endregion

        #region Contructor
        public Particao() {}

        #endregion

    }
}
