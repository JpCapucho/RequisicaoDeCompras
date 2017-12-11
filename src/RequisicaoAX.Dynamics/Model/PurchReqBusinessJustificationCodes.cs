using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequisicaoAX.Dynamics.Model
{
    public class PurchReqBusinessJustificationCodes
    {
        public string Description { get; set; }

        public string Reason { get; set; }

        public int RecVersion { get; set; }

        public long Partition { get; set; }

        public long RecID { get; set; }
    }
}
