using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequisicaoAX.Dynamics.Services
{
    public class Service
    {
        public void fazerAlgo()
        {
            var client = new Purch.PurchRFQSitesServiceClient();
            var result = client.read(GetContext(), new Purch.EntityKey[] {
                new Purch.EntityKey {
                    KeyData = new Purch.KeyField[] { new Purch.KeyField  {  Field = "", Value = ""} }
                }
            });


            var proxy = new Purch.PurchReqImportServiceClient();
            proxy.create(GetContext(), new Purch.AxdPurchReqImport
            {
                PurchReqTable = new Purch.AxdEntity_PurchReqTable[] {
                    new Purch.AxdEntity_PurchReqTable {
                        
                    }
                }
            });
        }


        /// <summary>
        /// Retorna o contexto atual
        /// </summary>
        /// <returns>object <see cref="Purch.CallContext"/></returns>
        public Purch.CallContext GetContext()
        {
            return new Purch.CallContext { Company = "log", Language = "pt-br" };
        }

    }
}
