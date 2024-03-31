using ECommerceAppBackend.Data;
using ECommerceAppBackend.Models;

namespace ECommerceAppBackend.Repositories.Items;

public class ItemsRepository : IItemsRepository
{
    private readonly AppDbContext _context;

    public ItemsRepository(AppDbContext context)
    {
        this._context = context;
    }

    public ItemModel GetItemById(int id)
    {
        var item = _context.Items.Find(id);
        return item!;
    }
    public IEnumerable<ItemModel> GetItems()
    {
        return _context.Items;
    }

    public List<ItemModel> OrderItemsAlphabetic()
    {
        return _context.Items.OrderBy(item => item.Name).ToList();
    }

    public void SaveItemModel(ItemModel item)
    {
         _context.Items.Add(item);
    }

    public void UpdateItemModel(ItemModel item)
    {
        _context.Items.Update(item);
    }

    public void Save()
    {
        _context.SaveChanges();
    }
}