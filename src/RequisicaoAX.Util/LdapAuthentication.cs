using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequisicaoAX.Util
{
    public class LdapAuthentication
    {
        private string _path;
        private string _filterAttribute;

        /// <summary>
        /// Construindo em ldap://cardexpress.corp
        /// </summary>
        public LdapAuthentication()
        {
            //Definindo o servidor de autenticação
            _path = "ldap://cardexpress.corp";
        }

        /// <summary>
        /// Construir especificando o caminho do servidor LDAP
        /// </summary>
        /// <param name="path">caminho do servidor ldap://<servername></param>
        public LdapAuthentication(string path)
        {
            //Definindo o servidor de autenticação
            _path = path;
        }

        public bool IsAuthenticated(string domain, string username, string pwd)
        {
            string domainAndUsername = string.Format(@"{0}\{1}", domain, username);
            DirectoryEntry entry = new DirectoryEntry(_path,
                                                       domainAndUsername, pwd);
            try
            {
                // Bind to the native AdsObject to force authentication.  
                Object obj = entry.NativeObject;

                DirectorySearcher search = new DirectorySearcher(entry)
                {
                    Filter = string.Format("(SAMAccountName={0})", username)
                };

                search.PropertiesToLoad.Add("cn");

                SearchResult result = search.FindOne();

                if (null == result)
                {
                    return false;
                }

                // Update the new path to the user in the directory 
                _path = result.Path;

                _filterAttribute = (String)result.Properties["cn"][0];
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao autenticar usuário. " + ex.Message);
            }
            return true;
        }

        public string GetGroups()
        {
            DirectorySearcher search = new DirectorySearcher(_path)
            {
                Filter = string.Format("(cn={0})", _filterAttribute)
            };

            search.PropertiesToLoad.Add("memberOf");

            StringBuilder groupNames = new StringBuilder();

            try
            {
                SearchResult result = search.FindOne();
                int propertyCount = result.Properties["memberOf"].Count;
                String dn;
                int equalsIndex, commaIndex;
                for (int propertyCounter = 0; propertyCounter < propertyCount;
                     propertyCounter++)
                {
                    dn = (String)result.Properties["memberOf"][propertyCounter];
                    equalsIndex = dn.IndexOf("=", 1);
                    commaIndex = dn.IndexOf(",", 1);
                    if (-1 == equalsIndex)
                    {
                        return null;
                    }
                    groupNames.Append(dn.Substring((equalsIndex + 1),
                                      (commaIndex - equalsIndex) - 1));
                    groupNames.Append("|");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter os nomes do grupo. " + ex.Message);
            }

            return groupNames.ToString();
        }
    }
}
