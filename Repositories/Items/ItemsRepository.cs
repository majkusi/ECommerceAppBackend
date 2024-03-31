using System.Collections.Immutable;
using ECommerceAppBackend.Data;
using ECommerceAppBackend.Models;

namespace ECommerceAppBackend.Repositories.Items;

public class ItemsRepository : IItemsRepository
{
    private readonly AppDbContext context;

    public ItemsRepository(AppDbContext context)
    {
        this.context = context;
    }

    public IEnumerable<ItemModel> GetItems()
    {
        return context.Items;
    }

    public List<ItemModel> OrderItemsAlphabetic()
    {
        return context.Items.OrderBy(item => item.Name).ToList();
    }

    public void SaveItemModel(ItemModel item)
    {
         context.Items.Add(item);
    }

    public void UpdateItemModel(ItemModel item)
    {
        context.Items.Update(item);
    }

    public void Save()
    {
        context.SaveChanges();
    }
}