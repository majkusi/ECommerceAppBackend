using ECommerceAppBackend.Data;
using ECommerceAppBackend.Models;

namespace ECommerceAppBackend.Repositories.Items;

public interface IItemsRepository
{
    IEnumerable<ItemModel> GetItems();
    List<ItemModel> OrderItemsAlphabetic();
    void SaveItemModel(ItemModel item);
    void UpdateItemModel(ItemModel item);
    ItemModel GetItemById(int id);
    void Save();
}