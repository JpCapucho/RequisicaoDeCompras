using RequisicaoAX.Model;
using System;

namespace RequisicaoAX.DAO
{
    /// <summary>
    /// Centraliza o acesso a dados de <see cref="Usuario"/>
    /// </summary>
    public class UsuarioDAO : NHibernate.Helper.Generics.GenericDAO<long, Usuario>
    {

    }

}
