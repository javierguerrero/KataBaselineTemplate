using Application.Responses;
using MediatR;

namespace Application.Queries
{
    public record GetAllItemsQuery() : IRequest<IEnumerable<ItemResponse>>;
}