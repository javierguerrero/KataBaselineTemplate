using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IItemRepository
    {
        Task<List<Item>> GetAllItems();

        Task<Item> CreateItem(Item item);
    }
}