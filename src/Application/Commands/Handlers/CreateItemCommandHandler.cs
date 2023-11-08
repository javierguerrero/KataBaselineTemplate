using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using MediatR;

namespace Application.Commands.Handlers
{
    public class CreateItemCommandHandler : IRequestHandler<CreateItemCommand, int>
    {
        private readonly IItemRepository _itemRepository;
        private readonly IMapper _mapper;

        public CreateItemCommandHandler(IItemRepository itemRepository, IMapper mapper)
        {
            _itemRepository = itemRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateItemCommand request, CancellationToken cancellationToken)
        {
            var res = await _itemRepository.CreateItem(new Item
            {
                Title = request.title,
                Description = request.description
            });
            return res.Id;
        }
    }
}