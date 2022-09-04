﻿using InvoiceKu.Administration;
using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<InvoiceKu.Purchase.PurchaseOrderRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = InvoiceKu.Purchase.PurchaseOrderRow;

namespace InvoiceKu.Purchase
{
    public interface IPurchaseOrderSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class PurchaseOrderSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPurchaseOrderSaveHandler
    {
        public PurchaseOrderSaveHandler(IRequestContext context)
             : base(context)
        {
        }


        protected override void BeforeSave()
        {
            base.BeforeSave();

            Row.SubTotal = 0;
            Row.BeforeTax = 0;
            Row.Discount = 0;
            Row.TaxAmount = 0;
            Row.Total = 0;
            foreach (var item in Row.ItemList)
            {
                Row.SubTotal += item.SubTotal;
                Row.BeforeTax += item.BeforeTax;
                Row.Discount += item.Discount;
                Row.TaxAmount += item.TaxAmount;
                Row.Total += item.Total;
            }

            Row.Total += Row.OtherCharge;


            if (this.IsCreate)
            {
                if (Row.Number.ToLower().Equals("auto"))
                {
                    var tenant = UnitOfWork.Connection.ById<TenantRow>(Row.TenantId);
                    var request = new GetNextNumberRequest()
                    {
                        Prefix = tenant.PurchaseNumberUseDate.Value ? tenant.PurchaseNumberPrefix + "/" + DateTime.Now.ToString("yyyyMMdd") : tenant.PurchaseNumberPrefix,
                        Length = tenant.PurchaseNumberLength.Value
                    };
                    var respone = MultiTenantHelper.GetNextNumber(UnitOfWork.Connection, request, MyRow.Fields.Number, tenant.TenantId);
                    Row.Number = respone.Serial;
                    Row.ProcurementGroup = Row.Number;
                }

            }
        }
    }
}