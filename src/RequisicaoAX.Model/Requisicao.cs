using System;
using System.Collections.Generic;
using System.Text;

namespace RequisicaoAX.Model
{
    /// <summary>
    /// Representa uma requisição de pedido de cotação
    /// </summary>
    public class Requisicao
    {
        #region Fields
        /// <summary>
        /// Identificador da requisição
        /// </summary>
        /// <remarks>
        /// Gerado automaticamente pelo SGDB
        /// </remarks>
        public virtual long Id { get; set; }

        /// <summary>
        /// Descricao da requisicao de compra
        /// </summary>
        public virtual string Nome { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual RequisicaoStatusEnum Status { get; set; }

        /// <summary>
        /// Usuario que criou a requisição
        /// </summary>
        public virtual Usuario CriadoPor { get; set; }

        /// <summary>
        /// Data de criação do registro
        /// </summary>
        public virtual DateTime? DataCriacao { get; set; } = DateTime.Now;
        
        /// <summary>
        /// Usuario que modificou a requisicao
        /// </summary>
        public virtual Usuario ModificadoPor { get; set; }

        /// <summary>
        /// Data da modificação
        /// </summary>
        public virtual DateTime? DataModificacao { get; set; }

        /// <summary>
        /// Usuario que aprovou a requisição
        /// </summary>
        public virtual Usuario AprovadoPor { get; set; }

        /// <summary>
        /// Data de aprovação
        /// </summary>
        public virtual DateTime? DataAprovacao { get; set; }

        /// <summary>
        /// Empresa vinculada a requisicao
        /// </summary>
        public virtual Empresa Empresa { get; set; }

        public virtual string Obs { get; set; }

        public virtual bool Visivel { get; set; }
        
        /// <summary>
        /// Produtos dessa cotação
        /// </summary>
        public virtual IList<Item> Itens { get; set; }


        #endregion


        #region Constructor
        public Requisicao() { }

        /// <summary>
        /// Construtor personalisado
        /// </summary>
        /// <param name="dataCriacao">Data da criação da requisição</param>
        /// <param name="criadoPor"><see cref="Usuario"/> que criou a requisição</param>
        public Requisicao(Usuario criadoPor, DateTime? dataCriacao = null)
        {
            this.DataCriacao = dataCriacao ?? DateTime.Now;
            CriadoPor = criadoPor;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Verifica se esta aprovado
        /// </summary>
        public virtual bool Aprovado() => this.DataAprovacao.HasValue ? true : false;


        #endregion
    }
}
