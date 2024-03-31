namespace ECommerceAppBackend.Models;

public class ShopCartModel
{
    public int Id { get; set; }
    public List<ItemModel>? ItemsInCart { get; set; }
    
}