using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequisicaoAX.Dynamics.Model
{
    public class EcoResProduct
    {
        public long? PRODUCTMASTER { get; set; }

        public int? RETAITOTALWEIGHT { get; set; }

        public int? VARIANTCONFIGURATIONTECHNOLOGY { get; set; }

        public string RETAILCOLORGROUPID { get; set; }

        public string RETAILSIZEGROUPID { get; set; }

        public string RETAILSTYLEGROUPID { get; set; }

        public int? ISPRODUCTVARIANTUNITCONVERSIONENABLED { get; set; }

        public long INSTANCERELATIONTYPE { get; set; }

        public string DISPLAYPRODUCTNUMBER { get; set; }

        public string SEARCHNAME { get; set; }

        public int PRODUCTTYPE { get; set; }

        public int PDSCWPRODUCT { get; set; }

        public string MODIFIEDBY { get; set; }

        public int RECVERSION { get; set; }

        public long RELATIONTYPE { get; set; }

        public long PARTITION { get; set; }

        public long RECID { get; set; }
    }
}
