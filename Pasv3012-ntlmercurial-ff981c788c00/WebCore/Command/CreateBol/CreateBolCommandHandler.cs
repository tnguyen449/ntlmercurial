using Data;
using Infrastructure.Decorator;
using Infrastructure.Repository;
using System;
using System.Data.Entity.Validation;
using System.Diagnostics;

namespace WebCore.Command
{
    public class CreateBolCommandHandler : ICommandHandler<CreateBolCommand>
    {
        public CreateBolCommandHandler()
        {
        }

        public void Handle(CreateBolCommand command)
        {
            var uow = new UnitOfWork<EF>();
            var newBol = new BillOfLanding();
            newBol.Id = command.Id;
            newBol.BolCode = command.BolCode;
            newBol.BolFromId = command.BolFromId;
            newBol.BolToId = command.BolToId;
            newBol.DeliveryType = command.DeliveryType;
            newBol.isDiscount = command.isDiscount;
            newBol.isGuarantee = command.isGuarantee;
            newBol.Liabilities = command.Liabilities;
            newBol.Prepaid = command.Prepaid;
            newBol.PrepaidTemp = command.PrepaidTemp;
            newBol.ReceiveDate = command.ReceiveDate;
            newBol.ReceiveTime = command.ReceiveTime;
            newBol.SendAddress = command.SendAddress;
            newBol.SendDate = command.SendDate;
            newBol.Sender = command.Sender;
            newBol.Receiver = command.Receiver;
            newBol.CreatedBy = command.CreatedBy;
            newBol.CreatedDate = command.CreatedDate;
            newBol.Description = command.Description;
            newBol.StatusCode = command.StatusCode;
            newBol.Total = command.Total;
            newBol.AdditionalFee = command.AdditionalFee;
            try
            {
                uow.Repository<BillOfLanding>().Add(newBol);
                uow.SubmitChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}",
                                                validationError.PropertyName,
                                                validationError.ErrorMessage);
                    }
                }
            }

           
        }
    }
}