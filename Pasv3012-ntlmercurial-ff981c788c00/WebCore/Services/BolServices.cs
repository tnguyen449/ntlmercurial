using Data;
using Domain.IServices;
using Domain.ViewModels;
using Infrastructure.Decorator;
using Infrastructure.Queries;
using System.Collections.Generic;
using WebCore.Command;
using WebCore.Queries;

namespace WebCore.Services
{
    public class BolServices : IService<BillOfLanding>, IBolServices
    {
        private readonly IQueryHandler<GetAllBolQuery, IEnumerable<BillOfLanding>> getAllBolHandler;
        private readonly ICommandHandler<AddMerchandiseCommand> addMerchandiseHandler;
        private readonly ICommandHandler<CreateBolCommand> createBolHandler;

        public BolServices(
            IQueryHandler<GetAllBolQuery, IEnumerable<BillOfLanding>> _getAllBolHandler,
            ICommandHandler<AddMerchandiseCommand> _addMerchandiseHandler,
            ICommandHandler<CreateBolCommand> _createBolHandler
            )
        {
            getAllBolHandler = _getAllBolHandler;
            addMerchandiseHandler = _addMerchandiseHandler;
            createBolHandler = _createBolHandler;
        }

        public IEnumerable<BillOfLanding> GetAllBol()
        {
            var logger = new ActivityLogForQueryHandlerDecorator<GetAllBolQuery, IEnumerable<BillOfLanding>>(getAllBolHandler);
            return logger.Handle(new GetAllBolQuery { });
        }

        public void AddItem(MerchandiseVM command)
        {
            addMerchandiseHandler.Handle(new AddMerchandiseCommand {Id=0,
                                                                    MerchandiseId = command.MerchandiseId,
                                                                    MerchandiseTypeId = command.merchandiseType.Id,
                                                                    Weight = (command.weight !=null)?int.Parse(command.weight):0,
                                                                    Quantity = (command.quantity != null) ? int.Parse(command.quantity):0,
                                                                    IsDeclare = command.isDeclared,
                                                                    DeclareValue = (command.declareValue != null)? command.declareValue: "",
                                                                    SpecialPrice = (command.specialPrice != null)?int.Parse(command.specialPrice):0,
                                                                    Description = command.description,
                                                                    SubTotal =command.subTotal,
                                                                
            });
        }

        public void CreateNewBol(BolVM command)
        {
            createBolHandler.Handle(new CreateBolCommand {  Id=0,
                                                            BolCode= command.bolCode,
                                                            AdditionalFee =(command.additionalFee!=null)?int.Parse(command.additionalFee):0,
                                                            BolFromId = 0,
                                                            BolToId = 0,
                                                            Description= "",
                                                            isDiscount =command.isDiscount,
                                                            isGuarantee = command.isGuarantee,
                                                            Liabilities = command.liabilities,
                                                            Prepaid = command.prepaid,
                                                            PrepaidTemp = command.prepaidTemp,
                                                            Total = command.total,
                                                            Receiver = "",
                                                            Sender = "",
                                                            ReceiveTime = System.DateTime.Now,
                                                            ReceiveDate = System.DateTime.Now,
                                                            SendAddress = command.sendAddress,
                                                            StatusCode = command.statusCode,
                                                            DeliveryType = command.deliveryType.Id,
                                                   
            });              
        }

       
    }
}