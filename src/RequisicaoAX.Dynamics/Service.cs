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
            var proxy = new Purch.PurchReqImportServiceClient();

            //var result = client.read(GetContext(), new Purch.EntityKey[1] {
            //    new Purch.EntityKey() {
            //        KeyData = new Purch.KeyField[1] {
            //            new Purch.KeyField()  {
            //                Field = "RECID",
            //                Value = "5637269856"
            //            }
            //        }
            //    }
            //});

            //var result = proxy.find(GetContext(), new Purch.QueryCriteria()
            //{
            //    CriteriaElement = new Purch.CriteriaElement[]
            //    {
            //        new Purch.CriteriaElement()
            //        {
            //            DataSourceName = "PurchReqTable",
            //            FieldName = "PurchReqId",
            //            Operator = Purch.Operator.Equal,
            //            Value1 = "025901",
            //        }
            //    }
            //});



            //var purchKey = proxy.create(GetContext(), new Purch.AxdPurchReqImport
            //{
            //    PurchReqTable = new Purch.AxdEntity_PurchReqTable[] {
            //        new Purch.AxdEntity_PurchReqTable {
            //            PurchReqName = "FC AIF TESTE",
            //            RequiredDateSpecified = true,
            //            RequiredDate = DateTime.Now,
            //            TransDateSpecified = true,
            //            TransDate = DateTime.Now,
            //            //Originator = "5637190326",
                        
            //            HeaderBusJustDetails = new Purch.AxdEntity_HeaderBusJustDetails[]
            //            {
            //                new Purch.AxdEntity_HeaderBusJustDetails
            //                {
            //                    BusinessJustification = "COMPRA PLANEJADA",                                
            //                    //action = Purch.AxdEnum_AxdEntityAction.create,
            //                }
            //            },

            //            BusinessJustificationDescription = "Detalhes adicionais para justificativa do negócio",

            //            ExternalSourceName = "DCI REQWEB",
            //            ExternalSourceID = "0001",
                        
            //            //se Projeto
            //            ProjId = "",

            //            //status
            //            RequisitionStatusSpecified = true,
            //            RequisitionStatus = Purch.AxdEnum_PurchReqRequisitionStatus.InReview,

            //            //linhas da requisicao
            //            PurchReqLine = new Purch.AxdEntity_PurchReqLine[]
            //            {
            //                new Purch.AxdEntity_PurchReqLine
            //                {

            //                    PurchQty = 10,
            //                    PurchQtySpecified = true,
            //                    BuyingLegalEntityDataArea = "LOG",

            //                    InventDim = new Purch.AxdEntity_InventDim[]
            //                    {
            //                        new Purch.AxdEntity_InventDim()
            //                        {
            //                            InventSiteId = "LOG_SJC",
            //                            InventColorId = "AZUL",
            //                            ConfigId = "PINCEL",
            //                            InventSizeId = "",
            //                            InventLocationId = "",
            //                        }
            //                    },
            //                    ItemId = "400011000",
            //                    //Name = "CANETA",
            //                    //DeliveryName = "CANETA DELIVERY",
                                
            //                    PriceUnitSpecified = true,
            //                    PriceUnit = 1,
            //                    CurrencyCode = "BRL",
            //                    ExternalItemId = "",
            //                    RequisitionStatusSpecified = true,
            //                    RequisitionStatus = Purch.AxdEnum_PurchReqRequisitionStatus.Draft,
            //                    //InventLocationId = "",

            //                    Requisitioner = "000365", //JP

            //                    RequiredDateSpecified = true,
            //                    RequiredDate = DateTime.Now,
            //                    TransDateSpecified = true,
            //                    TransDate = DateTime.Now,

            //                }
            //            }
            //        }


            //    },

            //    //DocPurpose = Purch.AxdEnum_XMLDocPurpose.Original,

            //    //ClearNilFieldsOnUpdate = Purch.AxdEnum_boolean.@true,

            //    //ClearNilFieldsOnUpdateSpecified = true,

            //    //DocPurposeSpecified = true,

            //    //SenderId = ""
            //});

            //var x = purchKey.ToString();
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
