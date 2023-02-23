using System;
using Application.Messaging;
using Application.Services;
using Domain.Entities;

namespace Application.Features.AppEntities.QuantityTypeFeatures.Commands.CreateQuantityType
{
    public class CreateQuantityTypeCommandHandler : ICommandHandler<CreateQuantityTypeCommand, CreateQuantityTypeCommandResponse>
    {
        private readonly IQuantityTypeService _quantityTypeService;

        public CreateQuantityTypeCommandHandler(IQuantityTypeService quantityTypeService)
        {
            _quantityTypeService = quantityTypeService;
        }

        public async Task<CreateQuantityTypeCommandResponse> Handle(CreateQuantityTypeCommand request, CancellationToken cancellationToken)
        {
            var quantityType = new QuantityType(request.Code,request.Name);
            await _quantityTypeService.CreateAsync(quantityType, cancellationToken);

            return new();
        }
    }
}

