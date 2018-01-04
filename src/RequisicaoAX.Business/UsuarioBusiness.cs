using RequisicaoAX.DAO;
using RequisicaoAX.Model;
using System;

namespace RequisicaoAX.Business
{
    /// <summary>
    /// Centraliza as regras de negócio de <see cref="Usuario"/>
    /// </summary>
    public class UsuarioBusiness : NHibernate.Helper.Generics.GenericBusiness<long, Usuario, UsuarioDAO>
    {

    }

}
