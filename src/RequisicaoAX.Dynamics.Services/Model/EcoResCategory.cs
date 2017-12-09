using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequisicaoAX.Dynamics.Model
{
    public class EcoResCategory
    {
        public int? REUSEENABLED { get; set; }

        public long CATEGORYHIERARCHY { get; set; }

        public long PARENTCATEGORY { get; set; }

        public string NAME { get; set; }

        public string CODE { get; set; }

        public int ISACTIVE { get; set; }

        public int CHANGESTATUS { get; set; }

        public long LEVEL_ { get; set; }

        public long NESTEDSETRIGHT { get; set; }

        public long NESTEDSETLEFT { get; set; }

        public int ISCATEGORYATTRIBUTESINHERITED { get; set; }

        public long INSTANCERELATIONTYPE { get; set; }

        public int ISTANGIBLE { get; set; }

        public long DEFAULTPROJECTGLOBALCATEGORY { get; set; }

        public decimal DEFAULTTHRESHOLD_PSN { get; set; }

        public string PKWIUCODE { get; set; }

        public DateTime MODIFIEDDATETIME { get; set; }

        public string MODIFIEDBY { get; set; }

        public DateTime CREATEDDATETIME { get; set; }

        public string CREATEDBY { get; set; }

        public int RECVERSION { get; set; }

        public long RELATIONTYPE { get; set; }

        public long PARTITION { get; set; }

        public long RECID { get; set; }
    }
}
