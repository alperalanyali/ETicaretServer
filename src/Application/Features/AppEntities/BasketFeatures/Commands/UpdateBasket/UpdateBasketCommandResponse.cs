using System;
using Application.Messaging;
using Application.Services;

namespace Application.Features.AppEntities.BasketFeatures.Commands.UpdateBasket
{
    public sealed record UpdateBasketCommandResponse(
        string Message = "İşlem başarılı"
        );

}

