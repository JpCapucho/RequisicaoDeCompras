using System.ComponentModel;

namespace RequisicaoAX.Model
{
    /// <summary>
    /// A finalidade da requisição
    /// </summary>
    public enum FinalidadeRequisicaoEnum
    {
        [Description("Consumo")]
        Consumo = 0,

        [Description("Reabastecimento")]
        Reabastecimento = 1
    }
}