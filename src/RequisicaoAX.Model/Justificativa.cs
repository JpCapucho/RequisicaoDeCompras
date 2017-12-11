using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequisicaoAX.Model
{
    /// <summary>
    /// Justificativas comerciais para o pedido
    /// </summary>
    public class Justificativa
    {
        /// <summary>
        /// Identificador unico
        /// </summary>
        public virtual string Id { get; set; }

        /// <summary>
        /// Descrição da justificativa comercial
        /// </summary>
        public virtual string Descricao { get; set; }


        public virtual bool Visivel { get; set; }

        /// <summary>
        /// Requisições vinculadas
        /// </summary>
        public virtual IList<Requisicao> Requisicoes { get; set; }
    }
}
