using Data;
using Infrastructure.Decorator;
using Infrastructure.Repository;
using System;

namespace WebCore.Command
{
    public class AddMerchandiseCommandHandler : ICommandHandler<AddMerchandiseCommand>
    {
        public void Handle(AddMerchandiseCommand command)
        {
            var newMerchandise = new Merchandise();
            newMerchandise.MerchandiseId = command.MerchandiseId;
            newMerchandise.MerchandiseTypeId = command.MerchandiseTypeId;
            newMerchandise.Quantity = command.Quantity;
            newMerchandise.Weight = command.Weight;
            newMerchandise.IsDeclare = command.IsDeclare;
            newMerchandise.DeclareValue = command.DeclareValue;
            newMerchandise.SpecialPrice = command.SpecialPrice;         
            newMerchandise.SubTotal = command.SubTotal;
            newMerchandise.CreatedBy = command.CreatedBy;
            newMerchandise.Description = command.Description;
            newMerchandise.CreatedDate = DateTime.Now;
            using (var uow = new UnitOfWork<EF>())
            {
                uow.Repository<Merchandise>().Add(newMerchandise);
                uow.SubmitChanges();
            }
        }
    }
}