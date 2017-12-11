using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequisicaoAX.Dynamics.Model
{
    public class PurchReqTable
    {
        public string PURCHREQID { get; set; }

        public string PURCHREQNAME { get; set; }

        public int PURCHREQTYPE { get; set; }

        public DateTime REQUIREDDATE { get; set; }

        public string PROJID { get; set; }

        public DateTime TRANSDATE { get; set; }

        public string SUBMITTEDBY { get; set; }

        public DateTime SUBMITTEDDATETIME { get; set; }

        public int SUBMITTEDDATETIMETZID { get; set; }

        public long BUSINESSJUSTIFICATION { get; set; }

        public string PROJIDDATAAREA { get; set; }

        public long ORIGINATOR { get; set; }

        public int ISMODIFIED { get; set; }

        public long SOURCEDOCUMENTHEADER { get; set; }

        public int REQUISITIONSTATUS { get; set; }

        public int ISWORKFLOWTOBERESUBMITTED { get; set; }

        public long COMPANYINFODEFAULT { get; set; }

        public string HOLDEXPLANATION { get; set; }

        public int ONHOLD { get; set; }

        public int REQUISITIONPURPOSE { get; set; }

        public DateTime MODIFIEDDATETIME { get; set; }

        public string MODIFIEDBY { get; set; }

        public DateTime CREATEDDATETIME { get; set; }

        public string CREATEDBY { get; set; }

        public int RECVERSION { get; set; }

        public long PARTITION { get; set; }

        public long RECID { get; set; }
    }
}
