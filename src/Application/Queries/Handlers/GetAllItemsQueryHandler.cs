using Application.Responses;
using AutoMapper;
using Domain.Interfaces;
using MediatR;

namespace Application.Queries.Handlers
{
    public class GetAllItemsQueryHandler : IRequestHandler<GetAllItemsQuery, IEnumerable<ItemResponse>>
    {
        private readonly IItemRepository _itemRepository;
        private readonly IMapper _mapper;

        public GetAllItemsQueryHandler(IItemRepository itemRepository, IMapper mapper)
        {
            _itemRepository = itemRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ItemResponse>> Handle(GetAllItemsQuery request, CancellationToken cancellationToken)
        {
            var items = await _itemRepository.GetAllItems();
            return _mapper.Map<IEnumerable<ItemResponse>>(items);
        }
    }
}