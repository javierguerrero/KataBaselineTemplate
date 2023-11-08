using MediatR;

namespace Application.Commands
{
    public record CreateItemCommand(string title, string description) : IRequest<int>;
}