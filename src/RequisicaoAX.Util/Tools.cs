using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequisicaoAX.Util
{
    /// <summary>
    /// Ferramentas e utilidades
    /// </summary>
    public class Tools
    {

        /// <summary>
        /// Verifica se o valor é Nulo, Vazio ou espaço em branco
        /// </summary>
        /// <param name="value">Valor a ser verificado</param>
        /// <returns>true or false</returns>
        public static bool IsNullOrEmpty(String value)
        {
            return string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value);
        }


    }
}
