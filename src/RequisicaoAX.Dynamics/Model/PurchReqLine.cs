using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequisicaoAX.Dynamics.Model
{
    public class PurchReqLine
    {
        public decimal LINENUM { get; set; }

        public string ITEMID { get; set; }

        public string INVENTDIMID { get; set; }

        public string NAME { get; set; }

        public int LINETYPE { get; set; }

        public decimal PURCHQTY { get; set; }

        public decimal PURCHPRICE { get; set; }

        public string CURRENCYCODE { get; set; }

        public string VENDACCOUNT { get; set; }

        public string URL { get; set; }

        public string PURCHRFQCASEID { get; set; }

        public DateTime REQUIREDDATE { get; set; }

        public decimal LINEAMOUNT { get; set; }

        public string DELIVERYNAME { get; set; }

        public long ADDRESSREFRECID { get; set; }

        public int ADDRESSREFTABLEID { get; set; }

        public string ATTENTION { get; set; }

        public decimal LINEDISC { get; set; }

        public decimal LINEPERCENT { get; set; }

        public decimal PRICEUNIT { get; set; }

        public decimal PURCHMARKUP { get; set; }

        public string TAXGROUP { get; set; }

        public string TAXITEMGROUP { get; set; }

        public int PURCHLINECREATED { get; set; }

        public Guid LINEREFID { get; set; }

        public string PURCHID { get; set; }

        public string PROJID { get; set; }

        public string PROJCATEGORYID { get; set; }

        public string ACTIVITYNUMBER { get; set; }

        public string PROJLINEPROPERTYID { get; set; }

        public int LINECOMPLETE { get; set; }

        public string PROJSALESCURRENCYID { get; set; }

        public decimal PROJSALESPRICE { get; set; }

        public string PROJTAXGROUPID { get; set; }

        public string PROJTAXITEMGROUPID { get; set; }

        public string PROJTRANSID { get; set; }

        public string EXTERNALITEMID { get; set; }

        public int ISSAVED { get; set; }

        public int SEQUENCENUMBER { get; set; }

        public DateTime TRANSDATE { get; set; }

        public int PURCHREQCONSOLIDATIONSTATUS { get; set; }

        public string VENDQUOTENUMBER { get; set; }

        public long PROCUREMENTCATEGORY { get; set; }

        public string INVENTLOCATIONID { get; set; }

        public string ASSETGROUP { get; set; }

        public long REASONREFRECID { get; set; }

        public long BUSINESSJUSTIFICATION { get; set; }

        public long SOURCEDOCUMENTLINE { get; set; }

        public long DEFAULTDIMENSION { get; set; }

        public long RECEIVINGOPERATINGUNIT { get; set; }

        public long PURCHREQTABLE { get; set; }

        public long BUYINGLEGALENTITY { get; set; }

        public string ASSETGROUPDATAAREA { get; set; }

        public string INVENTDIMIDDATAAREA { get; set; }

        public string INVENTLOCATIONIDDATAAREA { get; set; }

        public string ITEMIDDATAAREA { get; set; }

        public string PROJCATEGORYIDDATAAREA { get; set; }

        public string PROJTRANSIDDATAAREA { get; set; }

        public string PROJLINEPROPERTYIDDATAAREA { get; set; }

        public string PROJIDDATAAREA { get; set; }

        public string PROJTAXGROUPIDDATAAREA { get; set; }

        public string PROJTAXITEMGROUPIDDATAAREA { get; set; }

        public string PURCHRFQCASEIDDATAAREA { get; set; }

        public string PURCHIDDATAAREA { get; set; }

        public string ACTIVITYNUMBERDATAAREA { get; set; }

        public string TAXGROUPDATAAREA { get; set; }

        public string VENDACCOUNTDATAAREA { get; set; }

        public string TAXITEMGROUPDATAAREA { get; set; }

        public int ISPREPAYMENT { get; set; }

        public string PREPAYMENTDETAILS { get; set; }

        public long PURCHAGREEMENT { get; set; }

        public int RFQREQUIREMENT { get; set; }

        public long REQUISITIONER { get; set; }

        public long ASSETRULEQUALIFIEROPTION { get; set; }

        public long ASSETRULEQUALIFIEROPTIONLOCAL { get; set; }

        public string ITEMIDNONCATALOG { get; set; }

        public int ISMODIFIED { get; set; }

        public long ACCOUNTINGDISTRIBUTIONTEMPLATE { get; set; }

        public long DELIVERYPOSTALADDRESS { get; set; }

        public int REQUISITIONSTATUS { get; set; }

        public int ISPREENCUMBRANCEREQUIRED { get; set; }

        public long PURCHUNITOFMEASURE { get; set; }

        public long PROJSALESUNITOFMEASURE { get; set; }

        public int ISPURCHASEORDERGENERATIONMANUAL { get; set; }

        public string TAXSERVICECODE_BR { get; set; }

        public decimal MAXIMUMRETAILPRICE_IN { get; set; }

        public int EXCISERECORDTYPE_IN { get; set; }

        public decimal NONRECOVERABLEPERCENT_IN { get; set; }

        public int GTASERVICECATEGORY_IN { get; set; }

        public int EXCISETYPE_IN { get; set; }

        public int VATGOODSTYPE_IN { get; set; }

        public long COMPANYLOCATION_IN { get; set; }

        public long SERVICECODETABLE_IN { get; set; }

        public long EXCISETARIFFCODES_IN { get; set; }

        public long CUSTOMSTARIFFCODETABLE_IN { get; set; }

        public long SALESTAXFORMTYPES_IN { get; set; }

        public long VENDORLOCATION_IN { get; set; }

        public long CFOPTABLE_BR { get; set; }

        public long CFPSTABLE_BR { get; set; }

        public int DSA_IN { get; set; }

        public int PRICEDISCOUNTTRANSFER { get; set; }

        public int REQUISITIONPURPOSE { get; set; }

        public long SALESPURCHOPERATIONTYPE_BR { get; set; }

        public DateTime CREATEDDATETIME { get; set; }

        public string CREATEDBY { get; set; }

        public int RECVERSION { get; set; }

        public long PARTITION { get; set; }

        public long RECID { get; set; }

        public long BUDGETRESERVATIONLINE_PSN { get; set; }
    }
}
