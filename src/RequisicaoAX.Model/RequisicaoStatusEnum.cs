using System.ComponentModel;

namespace RequisicaoAX.Model
{
    public enum RequisicaoStatusEnum
    {
        Rascunho = 0,

        Enviado = 1,

        [Description("Conclusão pendente")]
        ConclusaoPendente = 2,

        [Description("Concluído")]
        Concluido = 3,

        [Description("Solicitação de cotação pendente")]
        PendenteRFQ = 4,

        [Description("Em revisão")]
        AprovacaoPendente = 5,

        [Description("Rejeitado")]
        Rejeitado = 6,

        [Description("Alteração solicitada")]
        AlteracaoSolicitada = 7,

        [Description("Aprovado")]
        Aprovado = 8,

        [Description("Aprovado - Parcialmente cancelado")]
        AprovadoParteCancelado = 9,

        [Description("Aprovado - Cancelado")]
        AprovadoCancelado = 10,

        [Description("Aprovado - Parcialmente encomendado")]
        AprovadoParteEncomendado = 11,

        [Description("Aprovado - Encomendado")]
        AprovadoEncomendado = 12,

        [Description("Aprovado - Parcialmente recebido")]
        AprovadoParteRecebido = 13,

        [Description("Aprovado - Recebido")]
        AprovadoRecebido = 14,

        [Description("Aprovado - Parcialmente faturado")]
        AprovadoParteFaturado = 15,

        [Description("Aprovado - Faturado")]
        AprovadoFaturado = 16,

        [Description("Cancelamento pendente")]
        CancelamentoPendente = 17
    }
}