using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequisicaoAX.Dynamics.Model
{
    public class Partition
    {
        public string PARTITIONKEY { get; set; }

        public string NAME { get; set; }

        public DateTime MODIFIEDDATETIME { get; set; }

        public int DEL_MODIFIEDTIME { get; set; }

        public string MODIFIEDBY { get; set; }

        public DateTime CREATEDDATETIME { get; set; }

        public int DEL_CREATEDTIME { get; set; }

        public string CREATEDBY { get; set; }

        public int RECVERSION { get; set; }

        public long RECID { get; set; }
    }
}
