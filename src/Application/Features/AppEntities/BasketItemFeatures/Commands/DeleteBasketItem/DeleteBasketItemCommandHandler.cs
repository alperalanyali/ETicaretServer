using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.BasketItemFeatures.Commands.DeleteBasketItem
{
	public class DeleteBasketItemCommandHandler:ICommandHandler<DeleteBasketItemCommand,DeleteBasketItemCommandResponse>
	{
        private readonly IBasketItemService _basketItemService;

        public DeleteBasketItemCommandHandler(IBasketItemService basketItemService)
        {
            _basketItemService = basketItemService;
        }

        public async Task<DeleteBasketItemCommandResponse> Handle(DeleteBasketItemCommand request, CancellationToken cancellationToken)
        {
            await _basketItemService.Delete(request.Id, cancellationToken);
            return new();
        }
    }
}

